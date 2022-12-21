import React from 'react'
import { BrowserRouter as Router } from 'react-router-dom'
import Routes from './app/routes'

import './custom.css'

export default function App() {
  return (
    <Router>
      <Routes />
    </Router>
  )
}
