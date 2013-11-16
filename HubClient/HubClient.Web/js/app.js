var demoHub = $.connection.demoHub;

$("#btnMyMethod").on("click", function () {
    console.log("about to call myMethod");
    demoHub.server.myMethod().done(function () {
        console.log("myMethod complete");
    });
});
$("#btnMyMethodParameter").on("click", function () {
    demoHub.server.myMethodWithParameters("kevin").fail(function () {
        alert("ERROR");
    });
});
$("#btnMyMethodParameterComplex").on("click", function () {
    demoHub.server.myMethodWithParameterComplex({
        Id: "abcdef"
    });
});

demoHub.client.alertMe = function (message) {
    console.log("ALERT ME: " + message);
};

$.connection.hub.logging = true;

$.connection.hub.connectionSlow(function () {
    console.log("Slow detection detected");
});

$.connection.hub.stateChanged(function (state) {
    if (state.newState == 0)
        console.log("STATE: Connecting...");
    else if (state.newState == 1)
        console.log("STATE: Connected...");
    else if (state.newState == 2)
        console.log("STATE: Reconnecting...");
    else if (state.newState == 3)
        console.log("STATE: Disconnected...");
    else
        console.log("STATE: Unknown");
});


var options = {
    transport: ['webSockets', 'longPolling']
};

var deferredStart = $.connection.hub.start(options);
deferredStart.done(function () {
    console.log("My connection id is " + $.connection.hub.id);
});
deferredStart.fail(function () {
    // error
});
