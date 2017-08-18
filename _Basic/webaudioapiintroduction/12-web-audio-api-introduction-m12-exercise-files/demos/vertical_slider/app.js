$(function() {

    var audioContext = new AudioContext();
    var oscillator;
    var val;

    $("#pad").on("mousedown", function() {
        oscillator = audioContext.createOscillator();
        oscillator.frequency.value = val || 0;
        oscillator.type = 2;
        oscillator.connect(audioContext.destination);
        oscillator.start(audioContext.currentTime)
    })

    $("#pad").on("mouseup", function() {
        oscillator.stop(audioContext.currentTime);
    })




    var sliderParams = {
        'orientation': "vertical",
        'range': "min",
        'min': 0,
        'max': 300,
        'animate': true,
        'step': 0.01,
        'slide': function(event, ui) {
            val = ui.value;

        },

        stop: function(event, ui) {}
    };

    $('#slider').slider(sliderParams);


});