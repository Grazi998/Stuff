window.onload=setup;
function setup(){
    document.addEventListener("deviceready",Prikazi);
    document.getElementById("dohvatipodatke").addEventListener("click",dohvati);


}

function Prikazi(){
    document.getElementById("spreman").innerHTML=" Uredaj je spreman ";
    document.getElementById("manufact").innerHTML="Proizvođač: "+device.manufacturer;
    document.getElementById("model").innerHTML="Model: "+device.model;
    document.getElementById("serijal").innerHTML="Serijski broj: "+device.serial;
    document.getElementById("cord").innerHTML="cordova: "+device.cordova;
    document.getElementById("platform").innerHTML="os: "+device.platform;
    document.getElementById("virtual").innerHTML="isvirtual: "+device.isvirtual;
    document.getElementById("uuid").innerHTML="uuid: "+device.uuid;
   
    
}

function dohvati(){
    document.getElementById("unosime").innerHTML=document.getElementById("ime").value;
    document.getElementById("unosmail").innerHTML=document.getElementById("email").value;
    if(document.getElementById("flip").value="true")
    {
        document.getElementById("unoszaposlen").innerHTML="DA"
    }
    if(document.getElementById("flip").value="false")
    {
        document.getElementById("unoszaposlen").innerHTML="NE"
    }
    document.getElementById("unosgodina").innerHTML=2019-document.getElementById("godina").value;
    if(document.getElementById("diplo").value="true")
    {
        document.getElementById("studij").innerHTML="diplomski"
    }
    if(document.getElementById("prediplo").value="true")
    {
        document.getElementById("studij").innerHTML="prediplomski"
    }
}