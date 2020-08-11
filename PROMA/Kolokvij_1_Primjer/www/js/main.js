window.onload=setup;

zahtjev=new XMLHttpRequest();

var rezultat;


function setup(){
    document.getElementById("provjera").addEventListener("click", Provjeri);
    document.getElementById("ocisti").addEventListener("click", ObrisiSpremnik);
    
}

function ObrisiSpremnik(){
    localStorage.clear();
    console.log("localstorageduljina ==> " + localStorage.length);
    alert("Spremnik obrisan!");

}

function Provjeri(){
    var populacijaInput;
    var drzavaInput;
    if(document.getElementById("populacija").value===""){
        alert("Unesi broj populacije!");
        return;
    }
    else{
        populacijaInput=document.getElementById("populacija").value;
    }

    if(document.getElementById("drzava").value.length<3){
        alert("Naziv države nije valjan!");
        return;
    }
    else if(!["italy", "croatia", "spain"].includes(document.getElementById("drzava").value)){;
        alert("Naziv drzave nije u popisu!");
        return;
    }
    else{
        drzavaInput=document.getElementById("drzava").value;
    }

    

    
    zahtjev.open("GET", `https://restcountries.eu/rest/v2/name/${drzavaInput}`, true);
    zahtjev.onreadystatechange=function(){
        if(zahtjev.status==200 && zahtjev.readyState==4){
            var odgovor = JSON.parse(zahtjev.responseText);
            var populacijaCompare;
            var podatakiz;
            var postoji = false;

            for(var i=0;i<localStorage.length;i++){
                if(localStorage.key(i)==drzavaInput){
                    postoji=true;
                }
            }
            
            if(localStorage.length==0 || !postoji){
                podatakiz="sa poslužitelja!";
                populacijaCompare = odgovor[0].population;
                localStorage.setItem(drzavaInput, populacijaCompare);
                alert("Rezultat je " + populacijaCompare);    
                console.log(localStorage);          
            }
            else{
                podatakiz="iz lokalnog spremnika!";
                populacijaCompare=localStorage.getItem(drzavaInput);
                console.log(localStorage);
                
            }

            if(populacijaInput==populacijaCompare){
                Ispis(populacijaInput, "Točan", podatakiz);
            }
            else if(populacijaInput>=populacijaCompare){
                Ispis(populacijaInput, "Odabrana država ima manje stanovnika!", podatakiz);
            }
            else if(populacijaInput<=populacijaCompare){
                Ispis(populacijaInput, "Odabrana država ima više stanovnika!", podatakiz);
            }
            
        }
    }
    zahtjev.send();
}

function Ispis(pok, rez, podiz){
    var mojpok=document.getElementById("pokusaj");
    var mojrez=document.getElementById("rezultat");
    var mojpodiz=document.getElementById("podatakdohvacen");

    mojpok.innerHTML="";
    mojrez.innerHTML="";
    mojpodiz.innerHTML="";

    mojpok.innerHTML="Vaš pokušaj je " + pok;
    mojrez.innerHTML="Rezulat: " + rez;
    mojpodiz.innerHTML="Podatak je dohvaćen " + podiz;
}