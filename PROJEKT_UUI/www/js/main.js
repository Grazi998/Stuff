window.onload=setup;
var moze=true;
var mozeBG=false;
var KLIJENTI;

function setup(){
    document.getElementById("loginBTN").addEventListener("click", LoginFade);
    document.getElementById("forgotten").addEventListener("click", ForPass);
    document.getElementById("REG").addEventListener("click", Register);
    for(var i=0;i<document.getElementsByClassName("x-btn").length;i++){
      document.getElementsByClassName("x-btn")[i].addEventListener("click", CloseLogIn);
    }
    $("#loginBTN").hover(Promijeni1, Promijeni2);
    document.getElementById("LIB").addEventListener("click", LoadSucelje);

    var zahtjevKlijenti=new XMLHttpRequest();
    zahtjevKlijenti.open("GET", "http://192.168.0.17:4000/Klijenti/", true);
    zahtjevKlijenti.onreadystatechange=function(){
      if(zahtjevKlijenti.status==200 && zahtjevKlijenti.readyState==4){
        KLIJENTI=JSON.parse(zahtjevKlijenti.response);
        };
    }
    zahtjevKlijenti.send();

    
}

function Register(){
  const user = document.getElementById("Rusername").value;
  const pass = document.getElementById("Rpass").value;
  var bod = new Object();
  bod={
    "korisnickoIme":user,
    "pass":pass
  }
  var zahReg=new XMLHttpRequest();
  zahReg.open("POST", "http://192.168.0.17:4000/Klijenti/", true);
  zahReg.onreadystatechange=function(){
    if(zahReg.status==200 && zahReg.readyState==4){
      console.log("OK");
      console.log(zahReg.response);
      };
  }
  zahReg.setRequestHeader("Content-Type", "application/json");
  zahReg.send(JSON.stringify(bod));

  window.location="sucelje2.html";
}


function LoadSucelje(){
  const user = document.getElementById("username").value;
  const pass = document.getElementById("pass").value;
  var provjera=false;

  for(var i=0;i<KLIJENTI.length;i++){
    if(KLIJENTI[i].korisnickoIme==user && KLIJENTI[i].pass==pass){
      sessionStorage.setItem("korisnik", KLIJENTI[i].korisnickoIme);
      sessionStorage.setItem("id", KLIJENTI[i]._id);
      provjera=true;
    }
  }
  if(!provjera){
    alert("Unos nije valjan!");
    window.location.reload();
  }
  else{
    window.location="getPicture.html";
  }

  
}
function Promijeni1(){
  mozeBG=true;
  document.body.style.backgroundColor="green";
  document.getElementById("loginBTN").style.backgroundColor="green";
  document.getElementById("loginBTN").style.boxShadow="20px 20px 40px green";
}
function Promijeni2(){
  if(mozeBG){
    document.body.style.backgroundColor="red";
    document.getElementById("loginBTN").style.backgroundColor="red";
    document.getElementById("loginBTN").style.boxShadow="10px 10px 20px red";
  }
  

}

function LoginFade(){
  if(moze){
    mozeBG=false;
    moze=false;
    
    $("#loginBTN").fadeOut(1200, function(){
      $("#container").fadeIn(500);
      
      TweenMax.from("#container", .4, { scale: 0, ease:setInterval.easeInOut});
      TweenMax.to("#container", .4, { scale: 1, ease:setInterval.easeInOut});
      
      moze=true;
      
  });  
  document.body.style.backgroundColor="green";
  document.getElementById("loginBTN").style.display="none";
  }
      
}

function CloseLogIn(){
  if(moze){
    moze=false;
    TweenMax.from("#container", .4, { scale: 1, ease:Sine.easeInOut});
    TweenMax.to("#container", .4, { left:"0px", scale: 0, ease:Sine.easeInOut});
    $("#forgotten-container").fadeOut(100, function(){
        $("#loginBTN").fadeIn(100);
    });
    $("#container").fadeOut(100, function(){
      $("#loginBTN").fadeIn(100);
      moze=true;
  });
  document.body.style.backgroundColor="red";
  document.getElementById("loginBTN").style.backgroundColor="red";
  document.getElementById("loginBTN").style.boxShadow="10px 10px 20px red";
  }
}

function ForPass(){
  if(moze){
    moze=false;
    $("#container").fadeOut(function(){
      $("#forgotten-container").fadeIn();
      moze=true;
    })

  }
  
}