import { useEffect, useState } from 'react'
import jwt from 'jwt-decode'

import useToken from './useToken'

export default function useCredential() {
  const [credential, setCredential] = useState({})
  const { token } = useToken()

  useEffect(() => {
    const credential = jwt(token)
    setCredential(credential)
  }, [token])

  return credential
}
