function audioFileLoader(fileDirectory) {
    var soundObj = {};
    soundObj.fileDirectory = fileDirectory;
    var playSound = audioContext.createBufferSource();
    var panner = audioContext.createPanner();
    var listener = audioContext.listener;


    var getSound = new XMLHttpRequest();
    getSound.open("GET", soundObj.fileDirectory, true);
    getSound.responseType = "arraybuffer";
    getSound.onload = function() {
        audioContext.decodeAudioData(getSound.response, function(buffer) {
            soundObj.soundToPlay = buffer;

        });
    }

    getSound.send();
    listener.dopplerFactor = 1;

    soundObj.setPannerPos = function(x, y, z) {
        panner.setPosition(x, y, z)
    }

    soundObj.setListenerPos = function(x, y, z) {
        listener.setPosition(x, y, z);

    }

    soundObj.setPannerVelocity = function(x, y, z) {
        panner.setVelocity(x, y, z)
    }









    soundObj.play = function() {

        playSound.buffer = soundObj.soundToPlay;
        playSound.connect(panner)
        panner.dopplerFactor = 50;

        panner.connect(audioContext.destination);
        playSound.start(audioContext.currentTime)
    }



    soundObj.stop = function() {
        playSound.stop(audioContext.currentTime)
    }

    return soundObj;
};