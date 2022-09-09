import logo from './logo.svg';
import './App.css';
import { useEffect } from "react";

function App() {

    const fetchUsers = () => {
        // Where we're fetching data from
        return fetch("https://localhost:44338/WeatherForecast")
            // We get the API response and receive data in JSON format
            .then((response) => response.json())
            .then((data) => console.log(data))
            .catch((error) => console.error(error));
    }

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
