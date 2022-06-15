const express = require('express');
const loginFunction = require('../services/adminAccount');

const clientDB = require('../../../dbConect');

const router = express.Router();


const verificarArticulo = async (nm) => {
    const checarQuery = `SELECT * FROM public.articulos`;
    const consultaWhoop = await clientDB.query(checarQuery);
    const p1 = new Promise( function(resolve, reject) { setTimeout(function() {  resolve(true)  },1) } )
    console.log(consultaWhoop.rows)
    try {
      await p1

      if (consultaWhoop.rows[0] !== undefined) {
            return { status: 200, contenido: consultaWhoop.rows };
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
    const idArticulo = req.query.idart;

    let h = await verificarArticulo(idArticulo);

    console.log(h);
    console.log(h.contenido)

    res.status(200).json(h.contenido)
    let time2 = performance.now(); //? Dev Check Performance
    let totalTime = time2 - time1;
    console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
    console.log(totalTime);
});

const verificarDatos = async () => {
  const checarQuery = `SELECT * FROM public.ventas`;
  const consultaWhoop = await clientDB.query(checarQuery);
  const p1 = new Promise( function(resolve, reject) { setTimeout(function() {  resolve(true)  },1) } )
  console.log(consultaWhoop.rows)
  try {
    await p1

    if (consultaWhoop.rows[0] !== undefined) {
          return { status: 200, contenido: consultaWhoop.rows };
    }
    else { return { status: 300 } }
  } catch (errorPG) {
    console.log(errorPG);
  }
}

router.get('/ventas', async (req, res) => {
  let time1 = performance.now(); //? Dev Check Performance
  /*const convertido =req.body
  const pName = req.body.uLName;*/

  console.log(req.query);
  const idArticulo = req.query.idart;

  let h = await verificarDatos();

  console.log(h);
  console.log(h.contenido)

  res.status(200).json(h.contenido)
  let time2 = performance.now(); //? Dev Check Performance
  let totalTime = time2 - time1;
  console.log(`TIMEE TAKED ${time1} + ${time2} // TIME LAPSED:`);
  console.log(totalTime);
});

module.exports = router;