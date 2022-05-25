const express = require('express');

// Login - LogOut
const createAccount = require('./api/account/create');
const infoArticulo = require('./api/account/login');
/*
const usersRouter = require('./api/account/delete');
const usersRouter = require('./api/account/logout');
*/
function routerApiPrivate(app, rateLimit) {
    const router = express.Router(), router2 = express.Router();

    app.use('/api', router2);

    router.use('/super/info', createAccount)
    router2.use('/super/articulo', infoArticulo)
}

module.exports = routerApiPrivate;