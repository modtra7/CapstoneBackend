import React, { useState } from 'react';
import { Link, Route, Router, Routes, Switch } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';
import axios from 'axios'
import Breaker from './components';
import { Home } from './components/Home';

const App = () => {
  
  const [game, setGame] = useState('')

  const handleGame = async () => {
    const response = await fetch('/,', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ game })
    })
    const data = await response.json()
    console.log(data);
  }

  return (
    <>
    <div>
      {/* <Router> */}
        <div>
          <ul>
            <li>
              <Link to='/'>Home</Link>
            </li>
            <li>
              <Link to='/breaker'>game</Link>
            </li>
          </ul>
          <hr />

          
            <Routes>
              <Route path='/'>
                <Home />
              </Route>
              <Route path='/breaker'>
                <Breaker />
              </Route>
            </Routes>
           
        </div>
      {/* </Router> */}
    </div>
    </>
  )
}

export default App