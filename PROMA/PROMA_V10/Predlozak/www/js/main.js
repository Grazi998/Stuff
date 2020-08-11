window.onload=setup;

function setup(){
    document.getElementById("play").addEventListener("click", Play);
    document.getElementById("pauza").addEventListener("click", Pauza);
    document.getElementById("stop").addEventListener("click", Stop);
    $("#glasnoca").on("change", Zvuk);
    document.getElementById("1").addEventListener("click", function(){
        document.getElementById("audio").src="res/01_prva.mp3";
    });
    document.getElementById("2").addEventListener("click", function(){
        document.getElementById("audio").src="res/02_druga.mp3";
    });
    document.getElementById("3").addEventListener("click", function(){
        document.getElementById("audio").src="res/03_treca.mp3";
    });
}

function Play(){
    var ispis=document.getElementById("vrijeme");
    var st;

    document.getElementById("audio").play();
    document.getElementById("glasnoca").volume=10;
    document.getElementById("audio").ontimeupdate=function(){
        var ct=parseInt(document.getElementById("audio").currentTime);
        if(ct!=st){
            st=ct;
            var sekunde=parseInt(st%60);
            var minute=parseInt((st%3600)/60);
            if((""+minute).length==1){
                minute="0"+minute;
            }
            if((""+sekunde).length==1){
                sekunde="0"+sekunde;
            }
            ispis.innerHTML=minute+":"+sekunde;
        }
        
    };
}
function Pauza(){
    document.getElementById("audio").pause();
}
function Stop(){
    document.getElementById("audio").pause();
    document.getElementById("audio").currentTime=0;
    document.getElementById("glasnoca").volume=10;
}
function Zvuk(){
    document.getElementById("audio").volume=document.getElementById("glasnoca").value/100;
}