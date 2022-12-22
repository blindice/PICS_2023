/** @jsxImportSource @emotion/react */
import React from 'react'
import { css } from '@emotion/react'
import { Navigate, Outlet } from 'react-router-dom'

import useToken from '../hooks/useToken'
import Header from '../components/Header'

export default function MainPage() {
  const { token } = useToken()

  const style = {
    container: css`
      height: 100vh;
      display: grid;
      grid-template-areas: 'header' 'content';
      grid-template-rows: 10.5vh 1fr;
    `,
    header: css`
      grid-area: header;
    `,
    content: css`
      grid-area: content;
    `,
  }

  if (!token) return <Navigate to="/" />

  return (
    <div css={style.container}>
      <div css={style.header}>
        <Header />
      </div>
      <div css={style.content}>
        <Outlet />
      </div>
    </div>
  )
}
