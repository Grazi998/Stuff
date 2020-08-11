window.onload=function(){
    document.addEventListener("deviceready", setup, false);
    document.getElementById("dohvati").addEventListener("touch", GetFunkcija);

}

var rezultat;
var ispis;
zahtjev=new XMLHttpRequest();

function setup(){
    zahtjev.open("GET", "http://localhost:4000/mobiteli", true);
    zahtjev.onreadystatechange=function(){
        if(zahtjev.readyState==4 && zahtjev.status==200){
            //PRIMANJE ODGOVORA
            rezultat=zahtjev.responseText;

            //PARSIRANJE ODGOVORA
            ispis=JSON.parse(rezultat);

            //ISPIS ODGOVORA
            document.getElementById("ispis").innerHTML="<strong>PODACI:</strong><br>";
            for(var i = 0 ; i< ispis.length; i++){        
                var zaispis="ID: " + ispis[i].id + "****Marka: "+ ispis[i].marka + "****Model: " + ispis[i].model + "****Cijena: "+ ispis[i].cijena;
                document.getElementById("ispis").innerHTML+=zaispis+"<br>";
            }

            }
     }
}



function GetFunkcija(){
    zahtjev.send();
}