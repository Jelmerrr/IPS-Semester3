import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from "react";
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr';

function App() {
  const [apiResponse, setApiResponse] = useState("placeholder");
  const [visibleText, setVisisbleText] = useState("placeholder");
  const [dataText, setdataText] = useState("placeholder");
  const [name, setName] = useState("");
  const [password, setPassword] = useState("");
  useEffect(() => {
    ApiCall()
    GetData()
  }, []);

  useEffect(() => {
    console.log(apiResponse.Response);
    setVisisbleText(apiResponse.Response)
  }, [apiResponse]);


  const ApiCall = async () => {
    try {
      let resp = await fetch('https://localhost:44338/User/checkCommunication')
      console.log(resp);
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

  const GetData = async () => {
    try {
      const connection = new HubConnectionBuilder()
        .withUrl("https://localhost:44379/SendDataHub")
        .withAutomaticReconnect()
        .configureLogging(LogLevel.Information)
        .build();

      connection.on("SendMethod", (a) => {
        console.log(a)
        updateText(a)
      });

      await connection.start();
    }
    catch (e) {
      console.log(e);
    }
  }

  const updateText = (newText) => {
    setdataText(newText);
  }

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          {visibleText}
        </p>
        <p>
          {dataText}
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
