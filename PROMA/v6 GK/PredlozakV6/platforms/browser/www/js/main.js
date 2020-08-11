window.onload=setup;
var zah;
var JSONzahtjev;

var dolar;
var kuna;
var funta;
var mult;
var edolar;
var ekuna;
var efunta;

function setup(){
    document.getElementById("btnDohvati").addEventListener("click", Dohvati);
    document.getElementById("btnInverz").addEventListener("click", Okreni);
}

function Okreni(){
    edolar=(mult/dolar*mult).toFixed(2);
    ekuna=(mult/kuna*mult).toFixed(2);
    efunta=(mult/funta*mult).toFixed(2);

    document.getElementById("numUSD").innerHTML=edolar;
    document.getElementById("numHRK").innerHTML=ekuna;
    document.getElementById("numGBP").innerHTML=efunta;

    document.getElementById("span1").innerHTML=" " + mult;
    document.getElementById("span2").innerHTML=" " + mult;
    document.getElementById("span3").innerHTML=" " + mult;
}

function Dohvati(){

    
    mult=parseInt(document.getElementById("input").value);
    if(isNaN(mult)){
        mult=1;
    }
    dolar=(mult*JSONzahtjev.rates.USD).toFixed(2);
    kuna=(mult*JSONzahtjev.rates.HRK).toFixed(2);
    funta=(mult*JSONzahtjev.rates.GBP).toFixed(2);

    document.getElementById("date").innerHTML=JSONzahtjev.date;
    
    document.getElementById("numUSD").innerHTML=mult;
    document.getElementById("numHRK").innerHTML=mult;
    document.getElementById("numGBP").innerHTML=mult;

    document.getElementById("span1").innerHTML=" " + dolar;
    document.getElementById("span2").innerHTML=" " + kuna;
    document.getElementById("span3").innerHTML=" " + funta;
    //document.getElementById("info").innerHTML=("1 " +JSONzahtjev.base + ":<br><br>").bold() + JSONzahtjev.rates.USD+" USD<br><br>"+JSONzahtjev.rates.HRK+" HRK<br><br>"+JSONzahtjev.rates.GBP+" GBP";
}

var zahtjev = new XMLHttpRequest();
zahtjev.onreadystatechange=Poruka;
zahtjev.open("GET", "https://api.exchangeratesapi.io/latest", true);
zahtjev.send();


function Poruka(){
    if(zahtjev.readyState==4 && zahtjev.status==200){
        zah=zahtjev.responseText;
        JSONzahtjev=JSON.parse(zah);
    }
}



