import React from 'react';
import ReactDOM from 'react-dom';
import './Styles/index.css';

import { Routes, Route } from 'react-router-dom';

import Home from './Pages/Home';

import Profile from './Pages/Profile'

import { BrowserRouter as Router } from 'react-router-dom';

ReactDOM.render(
  <React.StrictMode>
    <Router>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/profile' element={<Profile />} />
      </Routes>
    </Router>
  </React.StrictMode>,
  document.getElementById('root')
);