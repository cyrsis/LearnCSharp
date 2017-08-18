function log(texttolog) {
    var d = new Date();
    var time = padLeft(d.getHours(), 2) + ":" + padLeft(d.getMinutes(), 2) + ":" + padLeft(d.getSeconds(), 2) + ":" + padLeft(d.getMilliseconds(), 3);
    $('#logging_box').append(time + ": " + texttolog + "<br>");
    $('#logging_box').scrollTop($('#logging_box')[0].scrollHeight);
}
function padLeft(nr, n, str) {
    return Array(n - String(nr).length + 1).join(str || '0') + nr;
}

$(function () {
    'use strict';

    log("App Loaded");
    $('#signout').hide();

    var Application
    var client;
    Skype.initialize({
        apiKey: 'SWX-BUILD-SDK',
    }, function (api) {
        Application = api.application;
        client = new Application();
    }, function (err) {
        log('some error occurred: ' + err);
    });

    log("Client Created");
    
    // when the user clicks the "Sign In" button
    $('#signin').click(function () {
        $('#signin').hide();
        log('Signing in...');
        // and invoke its asynchronous "signIn" method
        client.signInManager.signIn({
            username: $('#address').text(),
            password: $('#password').text()
        }).then(function () {
            log('Logged In Succesfully');
            $('#loginbox').hide();
            $('#signout').show();

            var me = client.personsAndGroupsManager.mePerson;
            log('<b>Details about logged in user</b>');
            log('displayName: ' + me.displayName());
            log('supportsAudio: ' + me.supportsAudio());
            log('supportsVideo: ' + me.supportsVideo());

            if (me.supportsAudio() && me.supportsVideo()) {
                log('Current user supports both audio and video!');
            } else {
                log('The current user\'s PC doesn\'t support audio or video, so we can\t continue.');
            }


        }).then(null, function (error) {
            // if either of the operations above fails, tell the user about the problem
            log(error || 'Oops, Something went wrong.');
            $('#signin').show()
        });
    });

    // when the user clicks on the "Sign Out" button
    $('#signout').click(function () {
        // start signing out
        log("Signing Out");
        client.signInManager.signOut()
            .then(
                //onSuccess callback
                function () {
                    // and report the success
                    log('Signed out');
                    $('#loginbox').show();
                    $('#signin').show();
                    $('#signout').hide();
                },
            //onFailure callback
            function (error) {
                // or a failure
                log(error || 'Cannot Sign Out');
            });
    });

});