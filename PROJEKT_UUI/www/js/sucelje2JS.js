
window.onload=setup;
function setup(){
    nav = document.getElementById('nav');
    menu = document.getElementById('menu');
    menuToggle = document.querySelector('.nav__toggle');
    isMenuOpen = false;
    menuLinks = menu.querySelectorAll('.nav__link');
    menuToggle.addEventListener("click", TMAS);
    nav.addEventListener("keydown", TTINWO);
    korisnikId=sessionStorage.getItem("id");
    podaci=document.getElementsByClassName("gallery__item");
    document.getElementById("vault").addEventListener("click", function(){window.location.reload()});
    document.getElementById("account").addEventListener("click", PostaviZahtjev);
    document.getElementById("out").addEventListener("click", function(){window.location="index.html"});
    for(var i = 0; i < podaci.length;i++){
      podaci[i].addEventListener("click", PostaviZahtjev);
    }

}
var podaci;

var nav;
var menu;
var menuToggle;
var isMenuOpen;
var menuLinks;
var korisnikId;
var zah;
var sviPodaci;

function INFO(e){
  var pod=JSON.parse(sviPodaci);
  document.getElementById("glavni").innerHTML="";
  document.getElementById("glavni").innerHTML=pod[e];
  TMAS(event);
}

function Odabir(e){
  var pod=JSON.parse(sviPodaci);
  document.getElementById("glavni").innerHTML="";
  document.getElementById("glavni").innerHTML=pod[e];
}


function PostaviZahtjev(){
    var svi;
    var onEvent=event.target.id;
    console.log(onEvent);
    zah=new XMLHttpRequest();
    zah.open("GET", `http://192.168.0.17:4000/Klijenti/${korisnikId}`, true);
    zah.onreadystatechange=function(){
      if(zah.status==200 && zah.readyState==4){
        sviPodaci=zah.response;
        if(onEvent=="account"){
          INFO(onEvent)
        }
        else{
          Odabir(onEvent);
        }
        
        };
    }
    zah.send();
}

function TMAS(e){
    e.preventDefault();
    isMenuOpen = !isMenuOpen;
    // toggle a11y attributes and active class
    menuToggle.setAttribute('aria-expanded', String(isMenuOpen));
    menu.hidden = !isMenuOpen;
    nav.classList.toggle('nav--open');
}



// // TRAP TAB INSIDE NAV WHEN OPEN
function TTINWO(e){
    // abort if menu isn't open or modifier keys are pressed
  if (!isMenuOpen || e.ctrlKey || e.metaKey || e.altKey) {
    return;
  }
  
  // listen for tab press and move focus
  // if we're on either end of the navigation
  

  if (e.keyCode === 9) {
    if (e.shiftKey) {
      if (document.activeElement === menuLinks[0]) {
        menuToggle.focus();
        e.preventDefault();
      }
    } else if (document.activeElement === menuToggle) {
      menuLinks[0].focus();
      e.preventDefault();
    }
  }
}
