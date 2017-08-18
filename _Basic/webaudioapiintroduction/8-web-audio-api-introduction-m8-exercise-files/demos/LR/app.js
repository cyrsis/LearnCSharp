$(function() {
    var sound = audioFileLoader("siren.mp3");
    sound.setListenerPos(0, 0, 5);
    var leftButton = $('.left');
    var rightButton = $('.right');
    var play = $('.play');
    var stop = $('.stop');
    // set up listener and panner position information
    var xPos = 0;


    //_________ Move left _____________________________ 

    function moveLeft() {
        xPos += -0.66;
        sound.setPannerPos(xPos, 0, 0);
        leftLoop = requestAnimationFrame(moveLeft);
        return leftLoop;
    }

    leftButton.on("mousedown", function() {
        moveLeft();
    });


    leftButton.on("mouseup", function() {
        window.cancelAnimationFrame(leftLoop);
    });

    //_______ Move right ______________________________

    function moveRight() {
        xPos += 0.66;
        sound.setPannerPos(xPos, 0, 0);
        rightLoop = requestAnimationFrame(moveRight);
        return rightLoop;
    }


    rightButton.on("mousedown", function() {
        moveRight()
    });

    rightButton.on("mouseup", function() {
        window.cancelAnimationFrame(rightLoop);
    });


    //________Play & Stop __________________


    play.on("click", function() {
        sound.setPannerPos(xPos, 0, 0);
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