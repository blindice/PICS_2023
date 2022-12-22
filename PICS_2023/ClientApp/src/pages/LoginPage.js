import React, { lazy, Suspense } from 'react'
import { Navigate } from 'react-router-dom'
import useToken from '../hooks/useToken'

const Login = lazy(() => import('../feature/auth/login/Login'))

export default function LoginPage() {
  const { token } = useToken()

  if (token) return <Navigate to="dashboard" />

  return (
    <Suspense
      fallback={<p style={{ fontSize: 10 }}>Redirecting to PICS login...</p>}
    >
      <Login />
    </Suspense>
  )
}
