window.onload=init;

var zahtjev=new XMLHttpRequest();
var odgovor;
var sors;

function init(){
    document.addEventListener("deviceready", setup, false);
    document.getElementById("dohvati").addEventListener("click", DohvatiPod);
    document.getElementById("ocisti").addEventListener("click", Ocisti);
    console.log("Spremnik: " + localStorage.length);
}

function setup(){
    
}
function Ocisti(){
    localStorage.clear();
}


function DohvatiPod(){
    var postbroj=document.getElementById("broj").value;
    var postoji = false;
    if(postbroj<10000 || postbroj>53296){
        alert("Poštanski broj nije u rasponu postojećih!");
        return;
    }
    for(var i=0;i<localStorage.length;i++){
        if(localStorage.key(i)==postbroj){
            postoji=true;
        }
    }
    if(localStorage.length==0 || !postoji){
        zahtjev.open("GET", `http://api.zippopotam.us/HR/${postbroj}`, true);
        zahtjev.onreadystatechange=function(){
            if(zahtjev.status==200 && zahtjev.readyState==4){
                odgovor=JSON.parse(zahtjev.responseText);
                console.log(odgovor);
                localStorage.setItem(postbroj, zahtjev.responseText);
                Ispis();
            }
            else if(zahtjev.status==404 && zahtjev.readyState==4){
                alert("Unešeni poštanski broj ne postoji!");
            }
        
        }
        zahtjev.send();
        sors="API";
    }
    else{
        odgovor=JSON.parse(localStorage.getItem(postbroj));
        sors="LocalStorage";
        Ispis();
    }
    
}

function Ispis(){
    document.getElementById("izvor").innerHTML="";
    document.getElementById("drzava").value=odgovor.country;
    document.getElementById("zupanija").value=odgovor.places[0].state;
    document.getElementById("lokacija").value=odgovor.places.length;
    document.getElementById("izvor").innerHTML+=sors;

    var popis=document.getElementById("popis");
    popis.innerHTML="";

    odgovor.places.forEach(place => {
        var pDiv=document.createElement("div");
        pDiv.setAttribute("data-role", "collapsible");
        pDiv.setAttribute("data-collapsed", "true");
        pDiv.innerHTML+=`<h2>${place["place name"]}</h2> <p>longitude: ${place.longitude}<br>latitude: ${place.latitude}</p>`;
        popis.appendChild(pDiv);
    });
    
    $("#popis").trigger("create");
}