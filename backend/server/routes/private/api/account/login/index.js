const express = require('express');
const loginFunction = require('../services/adminAccount');

const router = express.Router();
function verifyToken(req, res, next) {
  const bearerHeader = req.headers['authorization'];

  if (bearerHeader) {
    const bearer = bearerHeader.split(' ');
    const bearerToken = bearer[1];
    req.token = bearerToken;
    next();
  } else {
    res.sendStatus(403);
  }
}


router.post('/', verifyToken, async (req, res) => {
    let time1 = performance.now(); //? Dev Check Performance
    const convertido =req.body
    const pName = req.body.uLName;
    const pPassword = req.body.uLPword;

    const elToken = req.token;
    console.log(convertido);
    if(pName != undefined && pPassword !== undefined){
        if(typeof pName === 'string' && typeof pPassword === 'string'){
            const pNameLength = pName.length, pPasswordLength = pPassword.length;
            if(pNameLength <= 16 && pPasswordLength <= 20){
                const loginFunctionTwo = await loginFunction(pName, pPassword, elToken);
                res.status(loginFunctionTwo.statusCode).json(loginFunctionTwo.infoReturned);
            }
        }
        else if(typeof pName == 'object' || typeof pPassword == 'object'){
            res.status(405).json({ error: 'Exceso de informacion' });
        }
        else {
            res.status(444).json({ error: 'Se presento un error, pero no sabemos porque, trata de contactar con soporte'});
        }
    } else {
        res.status(405).json({ error: 'Faltan datos' });
    }

    let time2 = performance.now(); //? Dev Check Performance
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime); 
});

module.exports = router;