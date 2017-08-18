"use strict"

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

        // object creation

        var playSound = audioContext.createBufferSource();
        playSound.buffer = soundObj.soundToPlay;

        var delay = audioContext.createDelay(audioContext.currentTime);
        delay.delayTime.value = 0.3;

        var playSoundDry = audioContext.createGain();
        var playSoundWet = audioContext.createGain();
        var playSoundMix = audioContext.createGain();
        var filter = audioContext.createBiquadFilter();
        filter.frequency.value = 1000;




        // audio controls ( params) 
        playSoundDry.gain.value = 1;
        playSoundWet.gain.value = 0.5;
        playSound.start(audioContext.currentTime)




        /* Routing diagram

         
          (-----------------<--___          
playSound -> delay-> playSoundWet^ ---playSoundMix-->destination
playSound-> playSoundDry ----------------^

Node graph                                */

        playSound.connect(delay);
        delay.connect(playSoundWet);
        playSoundWet.connect(filter);
        filter.connect(delay);

        playSound.connect(playSoundDry);
        playSoundDry.connect(playSoundMix)
        playSoundWet.connect(playSoundMix);
        playSoundMix.connect(audioContext.destination);





    }

    return soundObj;

}

var snare = audioFileLoader("snare.mp3");

window.addEventListener("keydown", snare.play, false)