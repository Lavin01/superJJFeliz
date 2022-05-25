const dotenv = require('dotenv');
dotenv.config();
const { Client } = require('pg');

const clientDB = new Client({
    host: process.env.DB_HOST,
    user: process.env.DB_USER,
    port: process.env.DB_PORT,
    password: process.env.DB_PASSWORD,
    database: process.env.DB_DATABASE
});

clientDB.connect(err => {
    if (err) {
      console.error('[DATABASE] ->', err.stack)
    } else {
      console.log('[DATABASE] CONECTADO');
    }
});

module.exports = clientDB;