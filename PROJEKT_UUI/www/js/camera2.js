window.onload=function(){
    videoEl=document.getElementById("video");
    document.getElementById("video").addEventListener("dblclick", Capture);
    canvas=document.getElementById("overlay");
    ctx=canvas.getContext("2d");
    this.document.getElementById("video").addEventListener("play", onPlay);
    this.Promise.all([
        faceapi.loadTinyFaceDetectorModel('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/'),
        faceapi.loadFaceLandmarkTinyModel('https://www.rocksetta.com/tensorflowjs/saved-models/face-api-js/')
    ]).then(run);
    
}
var videoEl;
var canvas, ctx;
var rezultat;

async function Capture(){
    var fixrez = rezultat;

    const regionsToExtract = [
        new faceapi.Rect(fixrez.detection.box.x, fixrez.detection.box.y, fixrez.detection.box.width, fixrez.detection.box.height)
      ]

    ctx.drawImage(videoEl, 0,0,canvas.width, canvas.height);
    var img=canvas.toDataURL("image/jpg");
    var slika=document.createElement("img");
    slika.src=img;
    const canvases = await faceapi.extractFaces(slika, regionsToExtract);
    var lice=canvases[0].toDataURL("image/jpg");
    sessionStorage.setItem("lice", lice);
    window.location="facerecognition.html";
}
  
function resizeCanvasAndResults(dimensions, canvas, results) {
    const { width, height } = dimensions instanceof HTMLVideoElement
      ? faceapi.getMediaDimensions(dimensions)
      : dimensions
    canvas.width = width
    canvas.height = height
  
    return results.map(res => res.forSize(width, height))
  }
  
    
  function drawDetections(dimensions, canvas, detections) {
    const resizedDetections = resizeCanvasAndResults(dimensions, canvas, detections)
    faceapi.drawDetection(canvas, resizedDetections)
  }
  
    
  function drawLandmarks(dimensions, canvas, results, withBoxes = true) {
    const resizedResults = resizeCanvasAndResults(dimensions, canvas, results)
    if (withBoxes) {
        faceapi.drawDetection(canvas, resizedResults.map(det => det.detection))
    }
    const faceLandmarks = resizedResults.map(det => det.landmarks)
    const drawLandmarksOptions = { lineWidth: 2, drawLines: true, color: 'green' }
    faceapi.drawLandmarks(canvas, faceLandmarks, drawLandmarksOptions)
  }    
      

    
  async function onPlay() {
     const options = new faceapi.TinyFaceDetectorOptions({ inputSize: 128, scoreThreshold : 0.3 }) 
  
     
     result = await faceapi.detectSingleFace(videoEl, options).withFaceLandmarks(true)
     rezultat=result;
     if (result) {
         drawLandmarks(videoEl, document.getElementById('overlay'), [result], true)
          
     }
     
      setTimeout(() => onPlay())
  }
  
  async function run() {
     const stream = await navigator.mediaDevices.getUserMedia({ video: {} })
     videoEl.srcObject = stream
  }
  
  