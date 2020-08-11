//Uključujemo paket "express"
const express = require('express')
const app = express();

const body_parser = require('body-parser');
// obradjuje zahtjeve tipa (application/json content-type)
app.use(body_parser.json());

// << db podaci >>
const db = require("./db");
const imeBaze = "LogIn";
const imeKolekcije = "Klijenti";
var ObjectId = require('mongodb').ObjectID;

db.spojNaBazu(imeBaze, imeKolekcije, function (dbCollection) { // callback za uspjesno spajanje 
 
    // CRUD rute za rad sa bazom
    app.post("/Klijenti", (req, res) => {
       const novi = req.body;
       dbCollection.insertOne(novi, (err, result) => { // callback za insertOne
          if (err) throw err;
          // vracamo cijelu listu (mozemo poslati samo "OK")
          dbCollection.find().toArray((_err, _result) => { // callback za find
             if (_err) throw _err;
             res.json(_result);
          });
       });
    });
 
    app.get("/Klijenti/:id", (req, res) => {
       const itemId = req.params.id;
        //Pretraga po parametru
       dbCollection.findOne({ _id: ObjectId(itemId) }, (err, result) => {
          if (err) throw err;
          // vracamo (jedan) rezultat
          res.json(result);
       });
    });

   //  app.get("/Klijenti/:id/:item", (req, res) => {
   //    const itemId = req.params.id;
   //    const itemA=req.param.item;
   //     //Pretraga po parametru
   //    dbCollection.findOne({ _id: ObjectId(itemId) }, (err, result) => {
   //       if (err) throw err;
   //       print(itemA)
   //       // vracamo (jedan) rezultat
   //       var rez=JSON.parse(result);
   //       res.json(result.pass);
   //    });
   // });
 
    app.get("/Klijenti", (req, res) => {
       // vrcamo cijeli niz
       dbCollection.find().toArray((error, result) => {
          if (error) throw error;
          res.json(result);
       });
    });
 
    app.put("/Klijenti/:id", (req, res) => {
       const itemId = req.params.id;
       const item = req.body;
       console.log("Promjena podatka: ", itemId, " na vrijednost:", item);
       dbCollection.updateOne({ _id: ObjectId(itemId) }, { slika: item }, (error, result) => {
          if (error) throw error;
          // vracamo natrag cijeli niz kako bi se mogli osvjeziti podaci
          dbCollection.find().toArray(function (_error, _result) {
             if (_error) throw _error;
             res.json(_result);
          });
       });
    });
 
    app.delete("/Klijenti/:id", (req, res) => {
       const itemId = req.params.id;
       console.log("Brisemo podatak sa ID: ", itemId);
 
       dbCollection.deleteOne({ _id: ObjectId(itemId) }, function (error, result) {
          if (error) throw error;
          // vracamo novo stanje podataka
          dbCollection.find().toArray(function (_error, _result) {
             if (_error) throw _error;
             res.json(_result);
          });
       });
    });
 
 }, function (err) { // callback za pogresku pri spajanju
    throw (err);
 });


app.use(function (req, res, next) {
    // Stranice (izvori) koji imaju pristup
    res.setHeader('Access-Control-Allow-Origin', '*');
    // Dozvoljene metode zahtjeva
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');
    // Dozvoljena zaglavlja zahjteva
    res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
    // Postaviti na TRUE ako je potrebno slanje cookie-ja uz zahtjev API-ju
    res.setHeader('Access-Control-Allow-Credentials', true);
    // Nastavi na iduci sloj
    next();
});


// Definiramo osnovnu rutu za GET zahtjev
app.get('/', (req, res) => res.send('Dobrodošli na moj server!'))


// Osluškuje konekcije za zadanom portu
app.listen(4000, () => console.log('Server sluša port 4000!'))





