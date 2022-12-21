import { configureStore } from '@reduxjs/toolkit'
import { baseApi } from './api'
import authReducer from '../feature/auth/slice'

export const store = configureStore({
  reducer: {
    [baseApi.reducerPath]: baseApi.reducer,
    authReducer,
  },
  middleware: (GetDefaultMiddleWare) =>
    GetDefaultMiddleWare().concat(baseApi.middleware),
})
