import { useState } from 'react'

export default function useToken() {
  const getToken = () => {
    const token = localStorage.getItem('token')
    if (!token) return null

    return token
  }

  const [token, setToken] = useState(getToken())

  const saveToken = (token) => {
    localStorage.setItem('token', token)
    setToken(token)
  }

  return { token, saveToken }
}
