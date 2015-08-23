/* File Created: August 22, 2013 */
/// <reference path="../jquery-1.10.2.min.js" />
/// <reference path="../jquery-ui-1.10.3.min.js" />

function resizeBody() {
    $("#wrapper").css("height", $(window).height());
    var h = parseInt($("#wrapper").css("height")) - (parseInt($("#pgHeader").css("height")) + parseInt($("#pgFooter").css("height")));
    $("#pgContent").css("height", h);
}

//Dynamically resizing the workspace width
//window.onresize = resizeBody();

$(document).ready(function () {
    //resizeBody();
});

