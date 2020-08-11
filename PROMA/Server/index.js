//Uključujemo paket "express"
const express = require('express')
// i stvaramo novu aplikaciju
const app = express();

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


const body_parser = require('body-parser');
// obradjuje zahtjeve tipa (application/json content-type)
app.use(body_parser.json());

// Ucitavamo podatke iz datoteke
let podaci = require('./face-api.min.js');

// Definiramo osnovnu rutu za GET zahtjev
app.get('/', (req,res) => res.send('Dobrodošli na moj server!'))

// Definiramo rutu koja vraća podatke kao JSON
app.get('/mobiteli', (req, res) => {
    res.json(podaci);
})

// GET ruta za dohvat jednog elementa po ID-u
app.get("/mobiteli/:id", (req, res) => {
    const idMobitela = req.params.id;
    // ID nam je spremljen kao string pa mozemo odmah raditi usporedbu
    const rezultat = podaci.find(i => i.id === idMobitela);
    // Provjera i vracanje odgovora
    if (rezultat) {
       res.json(rezultat);
    } else {
       res.json({ message: `Mobitel sa ID= ${idMobitela} ne postoji`})
    }
 });
 
// POST ruta za dodavanje novih podataka
 app.post("/dodaj", (req, res) => {
    const novi = req.body;
    console.log('Dodajem mobitel: ', novi);
 
    // dodajemo novi element u niz
    podaci.push(novi)
 
    // vracamo nove podatke
    res.json(podaci);
 });

 // promjena postojeceg podatka
app.put("/mobiteli/:id", (req, res) => {
   const idMobitela = req.params.id;
   const novi = req.body;
   console.log("Promjena mobitela: ", idMobitela, " u ", novi);

   const noviNizPodataka = [];
   // Prolazimo sa petljom kroz niz
   podaci.forEach(stari => {
      if (stari.id === idMobitela) {
         noviNizPodataka.push(novi);
         console.log("Nasao sam objekt za promjenu");
      } else {
         noviNizPodataka.push(stari);
      }
   });
   // mijenjamo stari niz sa novim
   podaci = noviNizPodataka;
   // vracamo novi skup podataka
   res.json(podaci);
});

// obrisi element iz niza
app.delete("/mobiteli/:id", (req, res) => {
   const idMobitela = req.params.id;

   console.log("Brisem mobitel ID: ", idMobitela);

   // filtriramo kopiju niza, bez elementa za brisanje
   const novi_niz = podaci.filter(i => i.id !== idMobitela);
   // zamjenjujemo stari niz sa novim
   podaci = novi_niz;

   res.json(podaci);
});

// Osluškuje konekcije za zadanom portu
app.listen(4000, () => console.log('Server sluša port 4000!'))

