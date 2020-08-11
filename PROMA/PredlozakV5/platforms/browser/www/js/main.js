var brojac=parseInt(localStorage.getItem("counter"));

window.onload=setup;


function setup(){
    document.getElementById("btnDodaj").addEventListener("click", Dodaj);
    document.getElementById("btnPrikazi").addEventListener("click", Prikazi);
    document.getElementById("btnObrisi").addEventListener("click", Obrisi);
    document.getElementById("idPjesma").value=brojac;
    
    
}

function Refresh(){
    brojac=parseInt(localStorage.getItem("counter"));
    document.getElementById("pjesma").value="";
    document.getElementById("autor").value="";
    document.getElementById("godina").value="";
    document.getElementById("idPjesma").value=brojac;
}

function Dodaj(){
    var podatakJSON ={ "naziv":document.getElementById("pjesma").value , "godina":document.getElementById("godina").value , "autor":document.getElementById("autor").value}
    localStorage.setItem(brojac, JSON.stringify(podatakJSON));
    localStorage.setItem("counter", parseInt(brojac)+1);
    document.getElementById("info").innerHTML="Podatak \""+ document.getElementById("autor").value + " : " + document.getElementById("pjesma").value + "\" je spremljen!";
    Refresh();
}
function Prikazi(){
    window.location="popis.html";

    // document.getElementById("info").innerHTML="POPIS PJESAMA <br><br>".fontsize(5);
    // if(localStorage.length==1){
    //     document.getElementById("info").innerHTML="Nema podataka!";
    // }
    // else{
    //     for(var i = 0; i < brojac ;i++){
    //         var pod = JSON.parse(localStorage.getItem(i));
    //         document.getElementById("info").innerHTML+="Naziv: ".bold() + pod.naziv+" -- Autor: ".bold()+ pod.autor + " -- Godina: ".bold()+ pod.godina + "<br>";
    //     }
    // }
}
function Obrisi(){
    localStorage.clear();
    localStorage.setItem("counter",0)
    document.getElementById("info").innerHTML="Popis obrisan!";
    Refresh();
}