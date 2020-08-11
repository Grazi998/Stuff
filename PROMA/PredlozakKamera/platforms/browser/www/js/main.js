


window.onload=function(){
    document.getElementById("slikaj").addEventListener("deviceready", function(){
        console.log(navigator.camera);
    }, false);
    document.getElementById("slikaj").addEventListener("click", Uslikaj);
}

function Uslikaj(){
    var options={
        quality: 80
    }
    // Navigator.camera.getPicture(Valja, Nevalja, options)
    console.log(navigator.camera)
}

function Valja(slika){
    document.getElementById("slika").src=slika;
}
function Nevalja(e){
    alert(e);
}