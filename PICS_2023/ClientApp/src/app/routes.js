import * as React from 'react'
import { useRoutes } from 'react-router-dom'
import LoginPage from '../pages/LoginPage'
import MainPage from '../pages/MainPage'
import DashboardPage from '../pages/DashboardPage'

export default function Routes() {
  let element = useRoutes([
    {
      path: '/',
      element: <LoginPage />,
    },
    {
      element: <MainPage />,
      children: [
        {
          path: 'dashboard',
          element: <DashboardPage />,
        },
      ],
    },
  ])
  return element
}
