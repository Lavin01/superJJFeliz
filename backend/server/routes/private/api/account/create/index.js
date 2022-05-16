const express = require('express');
const router = express.Router();

router.post('/', (req, res) => {

    let time1 = performance.now(); //? Dev Check Performance
    const { userRegisterName, userRegisterEmail, userRegisterPassword } = req.body;

    if(userRegisterName != undefined && userRegisterEmail != undefined && userRegisterPassword != undefined){ //? Detecta que existan los valores
      if(typeof userRegisterName === 'string' && typeof userRegisterEmail === 'string' && typeof userRegisterPassword === 'string'){
        if(userRegisterName.length >= 16 || userRegisterEmail.lenght >= 24 || userRegisterPassword.length >= 16){
            console.log('CUIDADOOOOOO!!! Una persona ha intentado sobre-cargar un array');
            res.status(400).json({
                Error: "Lo siento wey, al parecer estas intentando sobre cargar un array"
            });
        } else {
            const solicitudCreacion = service.create(userRegisterName, userRegisterEmail, userRegisterPassword);
            res.status(solicitudCreacion.statusCode).json(solicitudCreacion.infoReturned);
        }
      } else {
        res.status(400).json({
          Error: "Lo siento wey, al parecer no hay datos concurrentes"
        });
      }
    } else {
        res.status(400).json({
            Error: "Lo siento wey, al parecer no hay datos concurrentes"
        });
    }
    // DEV CHECK PREFORMANCE
    let time2 = performance.now();
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime);
});

module.exports = router;