"use strict"

function audioContextCheck() {
    if (typeof AudioContext !== "undefined") {
        return new AudioContext();
    } else if (typeof webkitAudioContext !== "undefined") {
        return new webkitAudioContext();
    } else if (typeof mozAudioContext !== "undefined") {
        return new mozAudioContext();
    } else {
        throw new Error('AudioContext not supported');
    }
}
var audioContext = audioContextCheck();

var audioBuffer;

var getSound = new XMLHttpRequest();
getSound.open("get", "snare.mp3", true);
getSound.responseType = "arraybuffer";

getSound.onload = function() {
    audioContext.decodeAudioData(getSound.response, function(buffer) {
        audioBuffer = buffer;
    });
};

getSound.send();


window.addEventListener("mousedown", playback);

function playback() {
    var playSound = audioContext.createBufferSource();
    playSound.buffer = audioBuffer;
    playSound.connect(audioContext.destination);
    playSound.start(audioContext.currentTime);
}