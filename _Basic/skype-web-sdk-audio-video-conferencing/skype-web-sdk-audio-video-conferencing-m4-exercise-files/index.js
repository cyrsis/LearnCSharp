// Dynamic arrays to store our contact data. As status and capabilities change,
// we need to keep a track of actual values in real-time.
var name_ids = new Array();
var contact_email = new Array();
var contact_status = new Array();
var contact_audio = new Array();
var contact_video = new Array();

// Global variables to track application state
var audio_started = false;
var audio_started = false;

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
    //ensure conversation panel is visible
    if (name_ids.length != -1) {
        $('#conversationheader').show();
        $('#conversationfooter').show();
        $('#conversationbox').show();
    }   
    //add the new participant to the conversation
    var sipaddress_id = sipaddress.replace(/[^a-z0-9]/gi, '');
    var newCard = '<div id="participant_' + sipaddress_id + '" class="alert alert-success">';
    newCard = newCard + 'Added ' + sipaddress;
    newCard = newCard + '</div>';
    $('#participantlist').append(newCard);
}


function invite_participant(name_id) {
    //log('Looking for ' + name_id);
    //log('Array Length=' + name_ids.length)
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

function renable_all_invite_options() {
    for (i = 0; i < name_ids.length; i++) {
        $('#invite_' + name_ids[i]).show();
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
    $('#conversationheader').hide();
    $('#conversationfooter').hide();
    $('#conversationbox').hide();
    $('#stopaudio').hide();
    $('#muteaudio').hide();
    $('#holdaudio').hide();
    $('#stopChat').hide();
    $('#keypad').hide();

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
            log('Sign In Error:' + error);
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

                    //log('displayName: ' + name);
                    var firstname = firstName(name);
                    //log('firstname: ' + firstname);

                    var status = person.status();

                    var modalities = person.capabilities;
                    modalities.video.changed(function (f) {
                        //log(firstname + 'v=' + f);
                        if (f === true) {
                            //log(firstname + ' supports video!!!');
                        }
                    });
                    modalities.audio.changed(function (f) {
                        //log(firstname + 'a=' + f);
                        if (f === true) {
                            //log(firstname + ' supports audio!!!');
                        }
                    });
                    modalities.audio.subscribe();
                    modalities.video.subscribe();

                    person.status.changed(function (status) {
                        // update the text to the new status
                        log(firstname + ' status: ' + status);

                        // No need to look up capabilities for anyone who isn't 'Online'
                        if (status === 'Online') {
                            //log('Looking for capabilities...');
                            person.capabilities.video.get().then(function (result) {
                                //log('Got video value for ' + firstname + ' which is ' + result);
                                videoSupported = result;
                            });
                            person.capabilities.audio.get().then(function (result) {
                                log('Got audio value for ' + firstname + ' which is ' + result);
                                audioSupported = result;
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

                    //createorUpdate(firstname, avatarUrl, audioSupported, videoSupported, status);

                });
            });
        });
    }
    $('#list_contacts').click(function () {
        list_contacts();
    });



    // configure this function to have global access, so can be called from the onClick handler
    window.add_participant_to_conversation = function (sipaddress) {
        conversation.addParticipant("sip:" + sipaddress).then(function () {
            log(sipaddress + ' added!');
            show_new_participant(sipaddress)         
            var participant_id = conversation.participants.length;
            log('Participants: ' + participant_id);

            conversation.participants(participant_id - 1).audio.state.changed(function (val) {
                log('Particpiant #' + participant_id + ' audio update: ' + val);
                if (val == 'Disconnected' && audio_started == true) {
                    //the participant has disconnected from the call, so remove them.
                    var sipaddress_id = sipaddress.replace(/[^a-z0-9]/gi, '');
                    $('#participant_' + sipaddress_id).remove();
                    $('#addaudio').show();
                    $('#stopaudio').hide();
                    //check if there is anyone left
                    check_if_no_more_participants();
                } else if (val == 'Connected') {
                    log('Particpiant #' + participant_id + ' started Audio remotely');

                    log('Local accept status: ' + conversation.audioService.accept.enabled());
                    if (conversation.audioService.accept.enabled() && audio_started == false) {
                        log("Able to accept incoming audio.")
                        conversation.audioService.start().then(function () {
                            log("Audio service has started");
                            conversation.audioService.accept().then(function () {
                                log("Added audio successfully!");
                                audio_started = true;
                                $('#addaudio').hide();
                                $('#stopaudio').show();
                                $('#muteaudio').show();
                                $('#holdaudio').show();
                                $('#keypad').show();
                            }).then(null, function (error) {
                                log('Error starting audio from participant:' + error);
                            });
                        }).then(null, function (error) {
                            log('Error starting audioservice:' + error);
                        });
                    } else {
                        if (audio_started) {
                            // audio already started, no need to re-start it
                        }
                        else
                        {
                            log("Unable to accept incoming audio automatically. Ignoring request. Let's add it manually.");
                            add_audio();
                        }
                    }                    
                }
            });
            conversation.participants(participant_id-1).audio.state.subscribe();

            conversation.participants(participant_id - 1).state.changed(function (val) {
                log('Particpiant #' + participant_id + ' conversation update: ' + val);
                if (val == 'Disconnected' && audio_started == true) {
                    //the participant has disconnected from the call, so remove them.
                    var sipaddress_id = sipaddress.replace(/[^a-z0-9]/gi, '');
                    $('#participant_' + sipaddress_id).remove();
                    //check if there is anyone left
                    check_if_no_more_participants();
                }
            });
            conversation.participants(participant_id - 1).state.subscribe();


        }).then(null, function (error) {
            log('Error adding participiant to conversation:' + error);
            if (error == 'Error: CommandDisabled') {
                log("chatService isn't started, so starting now.");
                start_chat();
            }
        });
    }

    function check_if_no_more_participants() {
        var participant_count = conversation.participants.length;
        log('Participants left:' + participant_count);
        if (participant_count <=0) {
            log("No more participants in conversation, closing.");
            stop_audio();
        }
    }

    $('#startChat').click(function () {
        start_chat();
    });
    function start_chat() {
        log('Starting chatService...');
        conversation.chatService.start().then(function () {
            log('chatService started!');
            $('#startChat').hide();
            $('#stopChat').show();
            conversation.selfParticipant.audio.state.changed(function (val) {
                log('Audio conversation update: ' + val);
                if (val == 'Notified') {                    
                     conversation.audioService.accept();
                }
            });
            conversation.selfParticipant.audio.state.subscribe();


        }).then(null, function (error) {
            log('Error strating the chatService:' + error);
        });
    }

    $('#stopChat').click(function () {
        stop_chat();
    });
    function stop_chat() {
        log('Stopping chatService...');
        conversation.chatService.stop().then(function () {
            log('chatService stopped.');
            $('#startChat').show();
            $('#stopChat').hide();
            $('#list_contacts').show();
            renable_all_invite_options();
            $('#participantlist').empty();
            $('#conversationheader').hide();
            $('#conversationfooter').hide();
            $('#conversationbox').hide();
            $('#keypad').hide();
        }).then(null, function (error) {
            log('Error stopping the chatService:' + error);
        });
    }

    // when the user clicks on the "Sign Out" button
    $('#signout').click(function () {
        sign_out();
    });
    function sign_out() {
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
                    $('#conversationheader').hide();
                    $('#conversationfooter').hide();
                    $('#conversationbox').hide();
                    $('#participantlist').empty();
                    $('#cards').empty();
                },
            //onFailure callback
            function (error) {
                // or a failure
                log('Cannot Sign Out. Error:' + error);
            });
    }

    // add audio to the conversation
    $('#addaudio').click(function () {
        add_audio();
    });
    function add_audio() {
        log("Adding audio to the conversation.");
        conversation.audioService.start().then(function () {
            log("Added audio successfully!");
            audio_started = true;
            $('#addaudio').hide();
            $('#stopaudio').show();
            $('#muteaudio').show();
            $('#holdaudio').show();
            $('#keypad').show();
            audio_started = true;
            var participant_count = conversation.participants.length;
            log('Participants in Conversation:' + participant_count);
        }).then(null, function (error) {
            log('Error starting audio:' + error);
        });
    }

    // stop or remove audio from the conversation
    $('#stopaudio').click(function () {
        stop_audio();
    });
    function stop_audio() {
        log("Removing audio from the conversation.");
        conversation.audioService.stop().then(function () {
            log("Audio has been removed.");
            $('#addaudio').show();
            $('#stopaudio').hide();
            $('#muteaudio').hide();
            $('#holdaudio').hide();
            $('#participantlist').empty();
            audio_started = false;
            stop_chat();
        }).then(null, function (error) {
            log('Error stopping audio:' + error);
        });
    }

    // mute audio from the conversation
    $('#muteaudio').click(function () {
        mute_audio();
    });
    function mute_audio() {
        log("Toggling the mute status of the Audio");
        log("Mute Status: " + conversation.selfParticipant.audio.isMuted());
        conversation.selfParticipant.audio.isMuted.set(!conversation.selfParticipant.audio.isMuted()).then(function () {
            log("Mute Toggled - new status: " + conversation.selfParticipant.audio.isMuted());
        }).then(null, function (error) {
            log('Error toggling mute status:' + error);
        });         
    }


    // place the conversation on hold 
    $('#holdaudio').click(function () {
        hold_audio();
    });
    function hold_audio() {
        log("Toggling the hold status of the Audio");
        var isOnHold = conversation.selfParticipant.audio.isOnHold();
        log("Hold Status: " + isOnHold);
        if (!isOnHold) {
            log("Placing audio on hold")
            conversation.selfParticipant.audio.isOnHold.set(true).then(function () {
                log('Audio placed on hold');
                isOnHold = conversation.selfParticipant.audio.isOnHold();
                log("Hold Status: " + isOnHold);
            }).then(null, function (error) {
                log('Error toggling hold status:' + error);
            });
        } else {
            log("Removing hold on audio")
            conversation.selfParticipant.audio.isOnHold.set(false).then(function () {
                log('Audio removed from hold');
                isOnHold = conversation.selfParticipant.audio.isOnHold();
                log("Hold Status: " + isOnHold);
            }).then(null, function (error) {
                log('Error toggling hold status:' + error);
            });
        }
    }

    // Sends a DTMF tone
    $('#send1').click(function () { send_dtmf_tone('1'); });
    $('#send2').click(function () { send_dtmf_tone('2'); });
    $('#send3').click(function () { send_dtmf_tone('3'); });
    $('#send4').click(function () { send_dtmf_tone('4'); });
    $('#send5').click(function () { send_dtmf_tone('5'); });
    $('#send6').click(function () { send_dtmf_tone('6'); });
    $('#send7').click(function () { send_dtmf_tone('7'); });
    $('#send8').click(function () { send_dtmf_tone('8'); });
    $('#send9').click(function () { send_dtmf_tone('9'); });
    $('#send0').click(function () { send_dtmf_tone('0'); });
    $('#sendstar').click(function () { send_dtmf_tone('Star'); });
    $('#sendpound').click(function () { send_dtmf_tone('Pound'); });
    function send_dtmf_tone(theTone) {
        if (conversation.selfParticipant.audio.isMuted() || conversation.selfParticipant.audio.isOnHold()) {
            log("Call on hold or muted, so can't send tone.");
        }
        else
        {
            log('Sending DTMF tone for ' + theTone);
            conversation.audioService.sendDtmf(theTone).then(function () {
                log('Tone sent');
            }).then(null, function (error) {
                log('Error sending tone:' + error);
            });
        }
    }



});