import express from 'express'
import userController from '../controllers/user.Controller'

export const userRouter = express.Router();

userRouter.post('/signup', userController.signup)
.post('/login', userController.login)
.post('/logedin', userController.verifyToken, userController.logedin)