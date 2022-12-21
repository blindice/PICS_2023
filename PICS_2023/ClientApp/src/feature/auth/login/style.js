import { css } from '@emotion/react'

export const style = {
  container: css`
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
  `,
  formContainer: css`
    margin-bottom: 10%;
    width: 250px;
  `,
  label: css`
    font-family: 'Nunito', sans-serif;
    font-weight: bold;
  `,
  input: css`
    margin-bottom: 0.5em;
  `,
  button: css`
    width: 100%;

    :focus {
      outline: none;
    }
  `,
}
