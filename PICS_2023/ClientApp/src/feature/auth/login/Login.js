/** @jsxImportSource @emotion/react */
import React from 'react'
import { useForm, Controller } from 'react-hook-form'
import TextField from '@mui/material/TextField'
import LoadingButton from '@mui/lab/LoadingButton'
import { toast } from 'react-toastify'
import { useNavigate } from 'react-router-dom'
import { motion } from 'framer-motion'

import Toast from '../../../components/Toast'
import { useLoginMutation } from '../api'
import { ResponseStatus as res } from '../../../util/Enum'
import useToken from '../../../hooks/useToken'
import { style } from './style'

export default function Login() {
  const { saveToken } = useToken()
  const [login, { isLoading }] = useLoginMutation()
  const navigate = useNavigate()
  const {
    control,
    handleSubmit,
    formState: { errors },
  } = useForm({
    defaultValues: { username: '', password: '' },
  })

  const handleFormSubmit = async (data) => {
    try {
      const { Status, result, Message } = await login(data).unwrap()

      if (Status === res.Error) toast(Message, { type: 'error' })
      else {
        saveToken(result)
        navigate('dashboard')
      }
    } catch (err) {
      toast(err, { type: 'error' })
    }
  }

  const animation = (myDelay) => {
    return {
      opacity: [0, 1],
      y: [-60, 0],
      transition: {
        type: 'spring',
        stiffness: 600,
        damping: 90,
        delay: myDelay,
      },
    }
  }

  return (
    <div css={style.container}>
      <div css={style.formContainer}>
        <motion.h2 css={style.label} animate={animation(0)}>
          Login
        </motion.h2>
        <form onSubmit={handleSubmit(handleFormSubmit)}>
          <motion.div animate={animation(0.1)}>
            <Controller
              name="username"
              control={control}
              rules={{ required: true }}
              render={({ field }) => (
                <TextField
                  {...field}
                  label="Username"
                  variant="outlined"
                  size="small"
                  fullWidth
                  error={errors.username ? true : false}
                  sx={style.input}
                />
              )}
            />
          </motion.div>
          <motion.div animate={animation(0.2)}>
            <Controller
              name="password"
              control={control}
              rules={{ required: true }}
              render={({ field }) => (
                <TextField
                  {...field}
                  label="Password"
                  type="password"
                  variant="outlined"
                  size="small"
                  fullWidth
                  error={errors.password ? true : false}
                  sx={style.input}
                />
              )}
            />
          </motion.div>
          <motion.div
            animate={animation(0.3)}
            whileHover={{ scaleX: 1.02, transition: { duration: 0.1 } }}
            whileTap={{ scale: 0.98 }}
          >
            <LoadingButton
              variant="contained"
              type="submit"
              loading={isLoading}
              sx={style.button}
            >
              Login
            </LoadingButton>
          </motion.div>
        </form>
      </div>
      <Toast />
    </div>
  )
}
