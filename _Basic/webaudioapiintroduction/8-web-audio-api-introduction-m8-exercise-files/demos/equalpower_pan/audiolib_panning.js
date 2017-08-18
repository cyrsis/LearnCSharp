var volume = 0.5;
x = null;
y = 0;
z = null;

var xDeg = 0;
var zDeg = xDeg + 90


zDeg = 180 - zDeg;


var x = Math.sin(xDeg * (Math.PI / 180));
var z = Math.sin(zDeg * (Math.PI / 180));



function audioFileLoader(fileDirectory) {
    var soundObj = {};
    soundObj.fileDirectory = fileDirectory;



    var getSound = new XMLHttpRequest();
    getSound.open("GET", soundObj.fileDirectory, true);
    getSound.responseType = "arraybuffer";
    getSound.onload = function() {
        audioContext.decodeAudioData(getSound.response, function(buffer) {
            soundObj.soundToPlay = buffer;

        });
    }

    getSound.send();


    soundObj.play = function() {

        console.log(zDeg)
        var playSound = audioContext.createBufferSource();
        var panner = audioContext.createPanner();
        playSound.buffer = soundObj.soundToPlay;

        panner.setPosition(x, y, z);

        panner.panningModel = 'equalpower';


        playSound.connect(panner);
        panner.connect(audioContext.destination)
        playSound.start(audioContext.currentTime)
    }

    return soundObj;
};

var snare = audioFileLoader("snare.mp3");


window.addEventListener("keydown", snare.play, false);