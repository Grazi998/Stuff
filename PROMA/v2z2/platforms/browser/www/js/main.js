window.onload=function(){
    $("#prviClanak").on("click", PrebaciNaPrvi);
    $("#drugiClanak").on("click", PrebaciNaDrugi);
    $("#slika").on("dblclick", Fullscreen);
    $("#slika").on("click", VratiSliku);
    $("#naslovnica").on("click", NaNaslovnicu);
    document.getElementById("slika").style.visibility="hidden";
    
}
var text1="The chicken nugget was invented in the 1950s by Robert C. Baker, a food science professor at Cornell University, and published as unpatented academic work.[4] This bite sized piece of chicken, coated in batter and then deep fried was called the Chicken Crispie by Baker and his associates. Dr. Baker's innovations made it possible to form chicken nuggets in any shape. Common problems the meat industry were facing at the time of this invention were being able to hold ground meat together without a skin and producing a batter that could handle being both deep fried and frozen without coming off of the desired meat. Baker was able to solve both problems by first coating the meat in vinegar, salt, grains, and milk powder to make it hold together and secondly using an egg and grain based batter that was able to be fried as well as frozen The McDonalds version of Chicken Nuggets are known as Chicken McNuggets. Their recipe was created on commission from McDonald's by Tyson Foods in 1979[6] and the product was sold beginning in 1980.";
var text2="In the UK and Ireland, adult male chickens over the age of one year are primarily known as cocks, whereas in the United States, Canada, Australia and New Zealand, they are more commonly called roosters. Males less than a year old are cockerels.[9] Castrated roosters are called capons (surgical and chemical castration are now illegal in some parts of the world). Females over a year old are known as hens, and younger females as pullets,[10] although in the egg-laying industry, a pullet becomes a hen when she begins to lay eggs, at 16 to 20 weeks of age. In Australia and New Zealand (also sometimes in Britain), there is a generic term chook /tʃʊk/ to describe all ages and both sexes.[11] The young are often called chicks Chicken originally referred to young domestic fowl.[12] The species as a whole was then called domestic fowl, or just fowl. This use of 'chicken' survives in the phrase 'Hen and Chickens', sometimes used as a British public house or theatre name, and to name groups of one large and many small rocks or islands in the sea (see for example Hen and Chicken Islands). The word 'chicken' is sometimes erroneously construed to mean females exclusively, despite the term 'hen' for females being in wide circulation, and the term “rooster” for males being that most commonly used. In the Deep South of the United States, chickens are also referred to by the slang term yardbird.";

function PrebaciNaPrvi(){
    document.getElementById("naslov").innerHTML="ČIKN NAGTS".fontsize(7);
    document.getElementById("parag").innerHTML=text1;
    document.getElementById("slika").src="img/ChickenNugg.jpg";
    document.getElementById("slika").style.visibility="visible";
    document.getElementById("prviClanak").style.visibility="hidden";
    document.getElementById("drugiClanak").style.visibility="visible";
    

}
function PrebaciNaDrugi(){
    document.getElementById("naslov").innerHTML="PRE-ČIKN NAGTS".fontsize(7);
    document.getElementById("parag").innerHTML=text2;
    document.getElementById("slika").src="img/Chicken.jpg";
    document.getElementById("slika").style.visibility="visible";
    document.getElementById("drugiClanak").style.visibility="hidden";
    document.getElementById("prviClanak").style.visibility="visible";
}
function Fullscreen(){
    var sheet1 = document.createElement("style");
    sheet1.innerHTML="img {width: 100%; height: 100%}";
    document.getElementById("slika").appendChild(sheet1);

}
function NaNaslovnicu(){
    window.location="index.html";
}
function VratiSliku(){
    var sheet2 = document.createElement("style");
    sheet2.innerHTML="img {max-width: 100%; display: block; margin-left: auto; margin-right: auto; width: 50%; border: 1px solid #ddd; border-radius: 4px; padding: 5px;}";
    document.getElementById("slika").appendChild(sheet2);
}