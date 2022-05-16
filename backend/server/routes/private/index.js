const express = require('express');

// Login - LogOut
const createAccount = require('./api/account/create');
const loginAccount = require('./api/account/login');
/*
const usersRouter = require('./api/account/delete');
const usersRouter = require('./api/account/logout');
*/
function routerApiPrivate(app, rateLimit) {
    const router = express.Router(), router2 = express.Router();
    const apiRequestLimiter = rateLimit({
      windowMs: 129000, // 1 minute 6 seg 5 * 60 * 1000
      max: 5, // limit each IP to 2 requests per windowMs,
      standardHeaders: true, // Return rate limit info in the `RateLimit-*` headers
      legacyHeaders: false,
      handler: function (req, res) {
        return res.status(429).json({
          error: 'N1003'
        })
      }
    })
    app.use('/api', router2);

    router.use('/super/info', createAccount)
    router2.use('/super/product', apiRequestLimiter, loginAccount)
}

module.exports = routerApiPrivate;