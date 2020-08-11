window.onload=setup;


var KLIJENT;

var korisnikID;
var INPUTslikaURL;
var COMPAREslikaURL;
var slikaI;
var slikaC;
var descriptor1;
var descriptor2;

function setup(){
    korisnikID=sessionStorage.getItem("id");
    console.log(korisnikID)
    var zahtjevKlijenti=new XMLHttpRequest();
    zahtjevKlijenti.open("GET", `http://192.168.0.17:4000/Klijenti/${korisnikID}`, true);
    zahtjevKlijenti.onreadystatechange=function(){
      if(zahtjevKlijenti.status==200 && zahtjevKlijenti.readyState==4){
        KLIJENT=JSON.parse(zahtjevKlijenti.response);
        Promise.all([
            //faceapi.loadSsdMobilenetv1Model('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/'),
            //faceapi.loadTinyFaceDetectorModel('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/'),
            //faceapi.loadFaceLandmarkTinyModel('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/'),
            faceapi.loadFaceLandmarkModel('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/'),
            faceapi.loadFaceRecognitionModel("https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/")
            //faceapi.loadMtcnnModel("https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/")
        ]).then(DajSlikuI).then(DajSlikuC).then(Usporedi);
        };
    };
    zahtjevKlijenti.send();
    
    
}


async function DajSlikuI(){
    document.body.innerHTML="DID U KNOW???";
    INPUTslikaURL=sessionStorage.getItem("lice");
    slikaI=await faceapi.fetchImage(INPUTslikaURL);
    document.body.append(slikaI);
    descriptor1 = await faceapi.computeFaceDescriptor(slikaI);  
}

async function DajSlikuC(){
    console.log(KLIJENT)
    COMPAREslikaURL=KLIJENT.slika;
    console.log(COMPAREslikaURL)
    slikaC=await faceapi.fetchImage(COMPAREslikaURL);
    document.body.append(slikaC);
    descriptor2 = await faceapi.computeFaceDescriptor(slikaC);
}
function Usporedi(){
    document.body.innerHTML="DID U KNOW???";
    var distance = faceapi.euclideanDistance(descriptor1, descriptor2);
    var rezultat=1-distance;
    console.log(distance);
    if(rezultat>=0.6){
        // KLIJENT.slika="OK";
        // console.log(KLIJENT);
        // var zahSlika=new XMLHttpRequest();
        // zahSlika.open("PUT", `http://192.168.0.17:4000/Klijenti/${korisnikID}`, true);
        // zahSlika.onreadystatechange=function(){
        //     if(zahSlika.status==200 && zahSlika.readyState==4){
        //         console.log(zahSlika.response);
        //         //window.location="sucelje2.html";
        //     }
        // }
        // zahSlika.send(JSON.stringify(KLIJENT));
        
        window.location="sucelje2.html";
        
    }
    else{
        alert("Lice nije prepoznato!\nVraćamo Vas na početnu!");
        window.location="index.html";
    }


}  