import { baseApi } from '../../app/api'

export const authApi = baseApi
  .enhanceEndpoints({ addTagTypes: 'Auth' })
  .injectEndpoints({
    endpoints: (build) => ({
      login: build.mutation({
        query: ({ username, password }) => ({
          url: 'login',
          method: 'POST',
          body: { username, password },
        }),
      }),
    }),
  })

export const { useLoginMutation } = authApi
