import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from "react";

function App() {
  const [apiResponse, setApiResponse] = useState("placeholder");
  useEffect(() => {
    ApiCall()
  }, []);

  useEffect(() => {
    console.log(apiResponse);
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

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          test
        </p>
      </header>
    </div>
  );
}

export default App;
