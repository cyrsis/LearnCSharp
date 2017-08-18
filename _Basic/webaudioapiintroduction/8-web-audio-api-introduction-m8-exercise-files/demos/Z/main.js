$(function() {
    var sound = audioFileLoader("siren.mp3");
    sound.setListenerPos(0, 0, 0);
    var zoomInButton = $('.zoomInButton');
    var zoomOutButton = $('.zoomOutButton');
    var play = $('.play');
    var stop = $('.stop');
    var icon = $('.icon');
    // set up listener and panner position information
    var xPos = 0;
    var zPos = 0;


    //_______ Zoom Out ______________________________

    function zoomOut() {
        zPos += 0.66;
        sound.setPannerPos(0, 0, zPos);
        zoomOutLoop = requestAnimationFrame(zoomOut);
        return zoomOutLoop;
    }

    zoomOutButton.on("mousedown", function() {
        zoomOut()

    });

    zoomOutButton.on("mouseup", function() {
        window.cancelAnimationFrame(zoomOutLoop);
    });

    //   _________ Zoom In _____________________________

    function zoomIn() {
        zPos += -0.66;
        sound.setPannerPos(0, 0, zPos);
        zoomInLoop = requestAnimationFrame(zoomIn);
        return zoomInLoop;
    }

    zoomInButton.on("mousedown", function() {
        zoomIn();
    });

    zoomInButton.on("mouseup", function() {
        window.cancelAnimationFrame(zoomInLoop);
    });


    //________Play & Stop __________________


    play.on("click", function() {
        sound.play()
        play.attr('disabled', 'disabled');
        console.log("play")

    });

    stop.on("click", function() {
        sound.stop()

        play.removeAttr('disabled');
        sound = audioFileLoader("siren.mp3");

    });

})