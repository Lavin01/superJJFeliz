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
/* const clientDB = new Client({
    host: 'database-coool.cvywfwuhhiax.us-east-2.rds.amazonaws.com',
    user: 'postgres',
    port: '5432',
    password: 'MpydbwDaKo3Ltasym6XU',
    database: 'superjj'
});
 */
clientDB.connect(err => {
    if (err) {
      console.error('[DATABASE] ->', err.stack)
    } else {
      console.log('[DATABASE] CONECTADO');
    }
});

module.exports = clientDB;