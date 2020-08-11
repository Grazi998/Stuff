
window.onload=setup;
var anuB;
function setup(){
    document.getElementById("LIB").addEventListener("click", function(){
      window.setTimeout(1000, function(){
        window.location="/izbornikAdmin";
        location.reload();
      });
      
    });
    document.getElementById("loginBTN").addEventListener("click", IzborLoad);
    for(var i=0;i<document.getElementsByClassName("x-btn").length;i++){
      document.getElementsByClassName("x-btn")[i].addEventListener("click", CloseContainers);
    }
    for(var i=0;i<document.getElementsByClassName("ANU").length;i++){
      anuB=document.getElementsByClassName("ANU")[i];
      anuB.addEventListener("click", ContainerLoad);
      
    }
    
}

function IzborLoad(){
  $("#loginBTN").fadeOut(1200, function(){
    $("#izbor").fadeIn(500);
    document.getElementById("izbor").style.display="flex";
    document.getElementById("izbor").style.flexDirection="column";
    
    TweenMax.from("#izbor", .4, { scale: 0, ease:setInterval.easeInOut});
    TweenMax.to("#izbor", .4, { scale: 1, ease:setInterval.easeInOut});            
}); 
}

function ContainerLoad(){
  document.getElementById("slovo").value=event.currentTarget.value;
  $("#izbor").fadeOut(1200, function(){
    $("#container").fadeIn(500);    
    TweenMax.from("#container", .4, { scale: 0, ease:setInterval.easeInOut});
    TweenMax.to("#container", .4, { scale: 1, ease:setInterval.easeInOut}); 
         
});
}

function CloseContainers(){
  TweenMax.from("#container", .4, { scale: 1, ease:Sine.easeInOut});
    TweenMax.to("#container", .4, { left:"0px", scale: 0, ease:Sine.easeInOut});
    $("#container").fadeOut(100, function(){
      $("#loginBTN").fadeIn(100);
  });
}