const dotenv = require('dotenv');
dotenv.config();
const { Client } = require('pg');

const clientDB = new Client({
    host: process.env.DB_HOST2,
    user: process.env.DB_USER2,
    port: process.env.DB_PORT2,
    password: process.env.DB_PASSWORD2,
    database: process.env.DB_DATABASE2
});

clientDB.connect(err => {
    if (err) {
      console.error('[DATABASE] ->', err.stack)
    } else {
      console.log('[DATABASE] CONECTADO');
    }
});

module.exports = clientDB;