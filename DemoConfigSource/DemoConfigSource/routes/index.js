import express from 'express'
import {userRouter} from './user.Router'
import {categoryRouter} from './category.Router'
import {companyRouter} from './company.Router'
import { teacherRouter } from './teacherrouter';
export const router = express.Router();

router.use('/users', userRouter);
router.use('/categories',categoryRouter);
router.use('/companies', companyRouter);
router.use('/teacher', teacherRouter);