// Dynamic arrays to store our contact data. As status and capabilities change,
// we need to keep a track of actual values in real-time.
var name_ids = new Array();
var contact_email = new Array();
var contact_status = new Array();
var contact_audio = new Array();
var contact_video = new Array();

function log(texttolog) {
    var d = new Date();
    var time = padLeft(d.getHours(), 2) + ":" + padLeft(d.getMinutes(), 2) + ":" + padLeft(d.getSeconds(), 2) + ":" + padLeft(d.getMilliseconds(), 3);
    $('#logging_box').append(time + ": " + texttolog + "<br>");
    $('#logging_box').scrollTop($('#logging_box')[0].scrollHeight);
}
function padLeft(nr, n, str) {
    return Array(n - String(nr).length + 1).join(str || '0') + nr;
}

function toTitleCase(str) {
    return str.replace(/\w\S*/g, function (txt) { return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase(); });
}

function firstName(name) {
    if (name.indexOf("@") != -1) {
        name = name.split("@")[0];
        if (name.indexOf(".") != -1) { name = name.split(".")[0]; }
        if (name.indexOf("_") != -1) { name = name.split("_")[0]; }
        if (name.indexOf("-") != -1) { name = name.split("-")[0]; }
    }
    else {
        name = name.split(" ")[0];
    }
    return toTitleCase(name);
}

function createorUpdate(name, avatarUrl, audioSupported, videoSupported, status, name_id) {

    var new_presence_state = '';
    if (status == 'Online') {
        new_presence_state = 'alert alert-success';
    }
    else if (status == 'DoNotDisturb') {
        new_presence_state = 'alert alert-dnd';
    }
    else if (status == 'Away') {
        new_presence_state = 'alert alert-warning';
    }
    else if (status == 'Busy') {
        new_presence_state = 'alert alert-danger';
    }
    else if (status == 'Offline') {
        new_presence_state = 'alert alert-offline';
    }    

    var newCard = '<div id="cardid_' + name_id + '" class="col-sm-3 ' + new_presence_state + '">';
    newCard = newCard + '<div style="float:left"><img src="' + avatarUrl + '" height="32" width="32" onError="imgError(this);" style="margin-right:10px;"></div>';
    newCard = newCard + name + '&nbsp&nbsp';
    if (audioSupported) {
        newCard = newCard + '&nbsp;<i class="glyphicon glyphicon-volume-up"></i>'
    }
    if (videoSupported) {
        newCard = newCard + '&nbsp;<i class="glyphicon glyphicon-facetime-video"></i>'
    }
    newCard = newCard + '<br><small>' + status + '</small>';
    newCard = newCard + '&nbsp;&nbsp;&nbsp;';

    if (status == 'Online') {
        newCard = newCard + '<div style="float:right;" id="invite_' + name_id + '"><a href="#" onClick="invite_participant(\'' + name_id + '\');">Invite</a></div>';
    }

    newCard = newCard + '</div>';

    if ($("#cardid_" + name_id).length == 0) {
        //log('No card found, adding...');
        $('#cards').append(newCard);
    } else {
        //log('this record already exists');
        $("#cardid_" + name_id).replaceWith(newCard);
    }   
}

function show_new_participant(sipaddress) {
    var newCard = '<div class="alert alert-success">';
    newCard = newCard + 'Added ' + sipaddress;
    newCard = newCard + '</div>';
    $('#participantlist').append(newCard);
}

function invite_participant(name_id) {
    var id = name_ids.indexOf(name_id);
    //log('Found #' + id);
    if (id != -1) {
        log("Adding " + contact_email[id] + " to the conversation.");
        var emailAddress = contact_email[id];
        //log("sip:" + emailAddress);
        add_participant_to_conversation(emailAddress);
        $('#invite_' + name_id).hide();
    }
}

// this function replaces a broken image with a generic face - indicating the contact doesn't have a photo.
function imgError(image) {
    image.onerror = "";
    image.src = "noimage.png";
    return true;
}

$(function () {
    'use strict';

    log("App Loaded");
    $('#loggedinbox').hide();

    var Application
    var client;
    var conversation;

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
            $('#loggedinbox').show();

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

            //create a new conversation
            log("Creating a new Conversation");
            conversation = client.conversationsManager.createConversation();

        }).then(null, function (error) {
            // if either of the operations above fails, tell the user about the problem
            log(error || 'Oops, Something went wrong.');
            $('#signin').show()
        });
    });

    function list_contacts() {
        $('#list_contacts').hide()
        log('Retrieving all contacts...');
        $('#cards').html("");
        client.personsAndGroupsManager.all.persons.get().then(function (persons) {
            log("Found Collection of persons");
            persons.forEach(function (person) {                

                person.displayName.get().then(function (name) {

                    var audioSupported = false;
                    var videoSupported = false;

                    var firstname = firstName(name);
                    var status = person.status();

                    person.status.changed(function (status) {
                        // update the text to the new status
                        log(firstname + ' status: ' + status);

                        // No need to look up capabilities for anyone who is 'Online'
                        if (status === 'Online') {
                            //log('Looking for capabilities...');
                            person.capabilities.video.get().then(function (result) {
                                log('Got video value for ' + firstname + ' which is ' + result);
                                videoSupported = true;
                            });
                            person.capabilities.audio.get().then(function (result) {
                                log('Got audio value for ' + firstname + ' which is ' + result);
                                audioSupported = true;
                            });
                        }

                        var name_id = name.replace(/[^a-z0-9]/gi, '');

                        person.emails.get().then(function (emails) {
                            var json_text = JSON.stringify(emails, null, 2).toString();
                            //log(name_id + ' : ' + json_text);
                            json_text = json_text.replace("[", "");
                            json_text = json_text.replace("]", "");
                            //log(name_id + ' : ' + json_text);
                            var obj = $.parseJSON(json_text);
                            //log(name_id + ' : ' + obj['emailAddress']);
                            var personuri = obj['emailAddress'];
                            //add name_id and email address into array
                            name_ids.push(name_id);
                            contact_email.push(personuri);
                        });

                        person.avatarUrl.get().then(function (avatarUrl) {
                            createorUpdate(firstname, avatarUrl, audioSupported, videoSupported, status, name_id);
                            
                        });
                        
                    });
                    person.status.subscribe();

                });
            });
        });
    }
    $('#list_contacts').click(function () {
        list_contacts();
    });

    // configure this function to have global access, so can be called from the onClick handler
    window.add_participant_to_conversation = function (sipaddress) {
        //alert('hi');
        conversation.addParticipant("sip:" + sipaddress).then(function () {
            log(sipaddress + ' added!');
            show_new_participant(sipaddress)
        }).then(null, function (error) {
            log('Error:' + error);
        });
    }    

    $('#startChat').click(function () {
        start_chat();
    });
    function start_chat() {
        log('Starting chatService...');
        conversation.chatService.start().then(function () {
            log('chatService started!');
            $('#startChat').hide();
        }).then(null, function (error) {
            log('Error:' + error);
        });
    }

    $('#stopChat').click(function () {
        stop_chat();
    });
    function stop_chat() {
        log('Stopping chatService...');
        conversation.chatService.stop().then(function () {
            log('chatService stopped.');
            $('#startChat').hide();
        }).then(null, function (error) {
            log('Error:' + error);
        });
    }

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
                    $('#list_contacts').show();
                },
            //onFailure callback
            function (error) {
                // or a failure
                log(error || 'Cannot Sign Out');
            });
    });

});