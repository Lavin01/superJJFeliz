const express = require('express');
const loginFunction = require('../services/adminAccount');

const clientDB = require('../../../dbConect');

const router = express.Router();


const verificarArticulo = async (nm) => {
    const checarQuery = `SELECT * FROM public.articulos WHERE codigo='${nm}' LIMIT 1`;
    const consultaWhoop = await clientDB.query(checarQuery);
    const p1 = new Promise( function(resolve, reject) { setTimeout(function() {  resolve(true)  },1) } )
    console.log(consultaWhoop.rows[0])
    try {
      await p1

      if (consultaWhoop.rows[0] !== undefined) {
            return { status: 200, contenido: consultaWhoop.rows[0] };
      }
      else { return { status: 300 } }
    } catch (errorPG) {
      console.log(errorPG);
    }
}

router.get('/', async (req, res) => {
    let time1 = performance.now(); //? Dev Check Performance
    /*const convertido =req.body
    const pName = req.body.uLName;*/

    console.log(req.query);
    const idArticulo = req.query.codigo;

    let h = await verificarArticulo(idArticulo);

    console.log(h);
    console.log(h.contenido)













   /* console.log(convertido);
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
*/
    res.status(200).json(h.contenido)
    let time2 = performance.now(); //? Dev Check Performance
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime);
});





const upArticulo = async (wn, wc, wd, wu, wco) => {

    console.log(wn)

    const checarQuery = `SELECT * FROM public.articulos WHERE codigo='${wco}' LIMIT 1`;
    const consultaWhoop = await clientDB.query(checarQuery);
    const p1 = new Promise( function(resolve, reject) { setTimeout(function() {  resolve(true)  },1) } )
    try {
         await p1
      
        if (consultaWhoop.rows[0] !== undefined) {
                return { status: 200, contenido: consultaWhoop.rows[0] };
        }
        else { 
            const sendQuery = `INSERT INTO public.articulos(nombre, cantidad, descripcion, unidad, codigo) VALUES ('${wn}', ${wc}, '${wd}', ${wu}, '${wco}');`;
            const sendReturnQuery = await clientDB.query(sendQuery);
            await p1
            console.log(sendReturnQuery);
            return { status: 300 }
        }
    } catch (errorPG) {
            console.log(errorPG);
    }
}

router.post('/', async (req, res) => {
    let time1 = performance.now(); //? Dev Check Performance

    console.log(req.query);

    let h = await upArticulo(req.query.nombre, req.query.cantidad, req.query.descripcion, req.query.unidad, req.query.codigo);

    console.log(h);

    res.status(200).json(h)
    let time2 = performance.now(); //? Dev Check Performance
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime);
});


router.delete('/', async (req, res) => {
    let time1 = performance.now(); //? Dev Check Performance

    console.log(req.query);

    let h = await upArticulo(req.query.nombre, req.query.cantidad, req.query.descripcion, req.query.unidad, req.query.codigo);

    console.log(h);

    res.status(200).json(h)
    let time2 = performance.now(); //? Dev Check Performance
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime);
});


module.exports = router;