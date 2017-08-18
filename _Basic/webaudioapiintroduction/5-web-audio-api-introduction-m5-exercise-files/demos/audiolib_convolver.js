"use strict"

function audioFileLoader(fileDirectory, impulseFileDirectory) {
    var soundObj = {};
    soundObj.fileDirectory = fileDirectory;
    soundObj.impulseFileDirectory = impulseFileDirectory;


    var getSound = new XMLHttpRequest();
    getSound.open("GET", soundObj.fileDirectory, true);
    getSound.responseType = "arraybuffer";
    getSound.onload = function() {
        audioContext.decodeAudioData(getSound.response, function(buffer) {
            soundObj.soundToPlay = buffer;

        });
    }

    getSound.send();

    var impulseBuffer;
    var getImpulse = new XMLHttpRequest();
    getImpulse.open("get", soundObj.impulseFileDirectory, true);
    getImpulse.responseType = "arraybuffer";
    getImpulse.onload = function() {
        audioContext.decodeAudioData(getImpulse.response, function(bufferImpls) {
            impulseBuffer = bufferImpls;
        });
    };

    getImpulse.send();





    soundObj.play = function() {

        // object creation

        var playSound = audioContext.createBufferSource();
        playSound.buffer = soundObj.soundToPlay;
        var playSoundDry = audioContext.createGain();
        var playSoundWet = audioContext.createGain();
        var playSoundMix = audioContext.createGain();
        var convolver = audioContext.createConvolver();
        convolver.buffer = impulseBuffer;

        // audio controls ( params) 
        playSoundDry.gain.value = 1;
        playSoundWet.gain.value = 0.1;
        playSound.start(audioContext.currentTime)




        /*_________Routing diagram__________________________________________


        playSound - > convolver - > playSoundWet---playSoundMix-- > destination
        playSound - > playSoundDry---------------- ^

        
        _________________________________________________________________*/



        //___________Node graph_____________

        playSound.connect(convolver);
        convolver.connect(playSoundWet);
        playSound.connect(playSoundDry);
        playSoundDry.connect(playSoundMix)
        playSoundWet.connect(playSoundMix);

        playSoundMix.connect(audioContext.destination);




    }

    return soundObj;

}

var sound = audioFileLoader("snare.mp3", "impulse.wav")

window.addEventListener("mousedown", sound.play)