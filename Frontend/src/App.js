import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from "react";

function App() {
  const [apiResponse, setApiResponse] = useState("placeholder");
  const [visibleText, setVisisbleText] = useState("placeholder");
  useEffect(() => {
    ApiCall()
  }, []);

  useEffect(() => {
    console.log(apiResponse[0].summary);
    setVisisbleText(apiResponse[0].summary)
  }, [apiResponse]);


  const ApiCall = async () => {
    try {
      let resp = await fetch('https://localhost:44379/WeatherForecast')
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
          {visibleText}
        </p>
      </header>
    </div>
  );
}

export default App;
