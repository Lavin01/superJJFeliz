const clientDB = require('../../../dbConect');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');
const dotenv = require('dotenv');
dotenv.config();

module.exports = loginFunction = async (userLoginName, userLoginPassword, elToken) => {

  const veriName = async (nm) => {
    const checarQuery = `SELECT * FROM public.users WHERE name='${nm}' LIMIT 1`;
    const consultaWhoop = await clientDB.query(checarQuery);
    const p1 = new Promise( function(resolve, reject) { setTimeout(function() {  resolve(true)  },1) } )
    try {
      await p1

      if (consultaWhoop.rows[0] !== undefined) {
        return true;
      }
      else { return false }
    } catch (errorPG) {
      console.log(errorPG);
    }
  }

  let rcConnect = await veriName(userLoginName);

  const saltRounds = 1;
  const myPlaintextPassword = 'Hi';
  const criptoPass = await bcrypt.hash(myPlaintextPassword, saltRounds).then(function (hash) {
    return hash;
  });
  console.log(criptoPass);
  const resultadoCoincidencia = await bcrypt.compare(myPlaintextPassword, criptoPass).then(function (result) {
    return result;
  });
  console.log(resultadoCoincidencia);

// Si la instancia del model se ejecutó con éxito
    // intentamos guardarlo en nuestra base de datos
    // utilizando una promesa (async/await)
  if (rcConnect == true) {
    try {
      var decoded = jwt.verify(elToken, process.env.API_KEY);
      console.log(decoded) // bar
    } catch (error) {
      
      console.log(error)
    }
    const token = jwt.sign(
      { name: userLoginName, id: '0' },
      process.env.API_KEY,
      { expiresIn: process.env.TOKEN_EXPIRES_IN,
      algorithm: 'HS512' },
    );
    return ({
      infoReturned: {
        token: token,
      },
      statusCode: '202'
    });
  } else {
    console.log('Testeo2');
    return ({
      infoReturned: {
        Info: 'Nombre/Password erroneo',
        nErr: '705'
      },
      statusCode: '203'
    });
  }
}