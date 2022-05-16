const express = require('express');
const rateLimit = require('express-rate-limit')

const routerApiPrivate = require('./routes/private');

const morgan = require('morgan');

const app = express();
const cors = require('cors');

const port = 3500;

const apiRequestLimiter = rateLimit({
  windowMs: 1000, // 1 minute 6 seg
  max: 10, // limit each IP to 2 requests per windowMs
  handler: function (req, res, /*next*/) {
    return res.status(429).json({
      error: 'Exceso de solicitudes'
    })
  }
})

//* Middleware
app.use(apiRequestLimiter)
app.use(morgan('dev'));
app.use(cors())
app.use(express.urlencoded({extended: false}));

app.use(express.json());

app.listen(port, () => {
    console.log(`Se inicio el servidor desde el puerto ${port}`);
});

routerApiPrivate(app, rateLimit);

// Recibir parametros GET


// Parametros tipo Query