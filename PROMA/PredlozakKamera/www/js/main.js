


window.onload=function(){
    
    document.getElementById("slikaj").addEventListener("click", Uslikaj);
}

function Uslikaj(){
    var options={
        quality: 80
    }
    if('mediaDevices' in navigator && 'getUserMedia' in navigator.mediaDevices){
        console.log("Let's get this party started");
      }
    // Navigator.camera.getPicture(Valja, Nevalja, options)
}

function Valja(slika){
    document.getElementById("slika").src=slika;
}
function Nevalja(e){
    alert(e);
}