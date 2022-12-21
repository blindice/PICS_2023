import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/dist/query/react'

export const baseApi = createApi({
  baseQuery: fetchBaseQuery({ baseUrl: 'https://localhost:44389/api' }),
  endpoints: () => ({}),
})
