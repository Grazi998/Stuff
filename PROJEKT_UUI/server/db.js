const express = require("express");

const app = express();
app.listen(8000, ()=>console.log("Server sluša port 8000!"));
app.use(express.static("public"));
app.use(express.json({limit : "1mb"}));

const database = new express("baza.db");
app.get("/", (req,res) => res.send("Dobrodošli!"));

app.post("/api", (request, response) => {
    console.log("Zahtjev dobiven!");
    const data = request.body;
    database.insert(data);
    response.json({
        status: "Success",
        name: "ime"

    })
})
//database.loadDatabase();
