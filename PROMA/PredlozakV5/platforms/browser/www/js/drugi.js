window.onload=setup;
var indeksi=[];
var brojac;
let tab;
var slike1;
var ind;
var provjera;

function setup(){
    document.getElementById("btnNazad").addEventListener("click", Nazad);
    document.getElementById("btnPopis").addEventListener("click", Provjera);
    
    tab = document.getElementById("popis");
    brojac=parseInt(localStorage.getItem("counter"));
    provjera = document.getElementById("provjera");
    
    //alert(typeof(localStorage.key(3)));
    for(var i =0;i<localStorage.length;i++){
        if(isValidNum(localStorage.key(i))){
            indeksi.push(localStorage.key(i));
        }
    }
    indeksi.sort();
    //alert(indeksi);
    dajPopis();

    
    slike1=[].slice.call(tab.getElementsByClassName("SlikeDel"),0);
    tab.addEventListener("click", function(e){
        ind = slike1.indexOf(e.target);;
        Izbrisi();
    });  
}

function isValidNum(x){
    if(isNaN(x)){
        return false;
    }
    else{
        return true;
    }
}

function Nazad(){
    window.location="index.html";
}

function Provjera(){
    //alert(indeksi.length)
    provjera.innerHTML="Provjera: <br>";
    for(var x=0;x<localStorage.length;x++){
        provjera.innerHTML+=localStorage.key(x) +" -- "+ localStorage.getItem(localStorage.key(x)) + "<br>";
    }
}

function Izbrisi(){
    localStorage.removeItem(localStorage.key(ind));
    localStorage.setItem("counter", brojac-1);
    window.location.reload();
    
}

function dajPopis(){
    indeksi.forEach(function(i){
        var pod=JSON.parse(localStorage.getItem(i))
        var r = tab.insertRow();
        var c1 = r.insertCell();
        var c2 = r.insertCell();
        var c3 = r.insertCell();
        var c4 = r.insertCell();
        c1.innerHTML=pod.naziv;
        c2.innerHTML=pod.autor;
        c3.innerHTML=pod.godina;
        c4.innerHTML="<img class=\"SlikeDel\" src=\"img/delete.png\" height=\"30px\" width=\"30px\">";
    })
}