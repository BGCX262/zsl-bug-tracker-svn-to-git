/* File Created: August 28, 2013 */
/// <reference path="../jquery-1.10.2.min.js" />
/// <reference path="../jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $("#form1").submit(function () {
        return $("#form1").valid();        
    });
});