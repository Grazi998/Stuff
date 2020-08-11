const express=require("express");
const app = express();

//VAŽNOOOO!!!!!
// *************************************************************************************************
app.use(function (req, res, next) {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');
    res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
    res.setHeader('Access-Control-Allow-Credentials', true);
    next();
 });
// *************************************************************************************************

app.get("/", (req,res) => res.send("Dobrodošli na MojServer!"));
app.listen(4000, () => console.log("Server sluša port 4000"));