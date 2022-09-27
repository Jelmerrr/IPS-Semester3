import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from "react";

function App() {
  const [apiResponse, setApiResponse] = useState("placeholder");
  const [visibleText, setVisisbleText] = useState("placeholder");
  const [name, setName] = useState("");
  const [password, setPassword] = useState("");
  useEffect(() => {
    ApiCall()
  }, []);

  useEffect(() => {
    console.log(apiResponse[0].summary);
    setVisisbleText(apiResponse[0].summary)
  }, [apiResponse]);


  const ApiCall = async () => {
    try {
      let resp = await fetch('https://localhost:44338/WeatherForecast')
      let respJson = await resp.json()
      setApiResponse(respJson)
    }
    catch (e) {
      console.log(e);
    }
  }

  const handleSubmit = (event) => {
    event.preventDefault();
    alert(`The details you entered are: ${name} and ${password}`)
    CreateAccount()
  }

  const CreateAccount = async () => {
    try {
      console.log("sending");
      const response = await fetch(`https://localhost:44338/User/createUser/${name}/${password}`, {
        method: 'POST'
      })
      var response_data = await response.json();
      return (response_data);
    }
    catch (e) {
      console.log(e);
    }
  }

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          {visibleText}
        </p>
        <form onSubmit={handleSubmit}>
          <label>
            Name:
            <input type="text" name="name" onChange={(e) => setName(e.target.value)} />
          </label>
          <label>
            Password:
            <input type="text" name="password" onChange={(e) => setPassword(e.target.value)} />
          </label>
          <input type="submit" value="Submit" />
        </form>
      </header>
    </div>
  );
}

export default App;
