window.onload=init;

var spil = new XMLHttpRequest();
var objectSpil;
var id="";
var counter=0;
var objectKarta;


function init(){
    document.addEventListener("deviceready", setup,  false);
    document.getElementById("btnDohvati").addEventListener("click", DohvatiSpil);
    document.getElementById("btnKarta").addEventListener("click", DohvatiNovuKartu);
}

function setup(){
    // console.log(counter);
    // counter++;
    spil.open("GET", "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1", true);
    spil.onreadystatechange=function(){
        if(spil.readyState==4 && spil.status==200){
            objectSpil=JSON.parse(spil.responseText);
        }
        else{
            return;
        }
        
    }
    if(id==""){
        spil.send();
        //alert("Špil dohvaćen!");
    }
    else{
        alert("Špil je već dohvaćen!");
    }
    

}

function DohvatiSpil(){
    id=objectSpil.deck_id;
    console.log(objectSpil);
    document.getElementById("provjera").innerHTML=id;
    
    var karta = new XMLHttpRequest();
    karta.open("GET", `https://deckofcardsapi.com/api/deck/${id}/draw/?count=1`, true);
    karta.onreadystatechange=function(){
        //alert(karta.status + "  " + karta.readyState)
        
        if(karta.readyState==4 && karta.status==200){
            console.log(karta.responseText);
            objectKarta=JSON.parse(karta.responseText);
            
        }
    }
    karta.send();
    //alert(id);
}

function DohvatiNovuKartu(){
    

    console.log(objectKarta)

    document.getElementById("nazivKarte").innerHTML+=objectKarta.cards[0].value + " OF " + objectKarta.cards[0].suit;
    
    document.getElementById("slikaKarte").innerHTML=`<img src=${objectKarta.cards[0].image}>`;

}