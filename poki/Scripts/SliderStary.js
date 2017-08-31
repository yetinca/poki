$(document).ready(function () {

    var handle = $("#custom-handle");
    $("#pytanie1").slider({
        create: function () {
            handle.text($(this).slider("value"));
            $("#pytanie1").val($(this).slider("value"));
        },
        slide: function (event, ui) {
            handle.text(ui.value);
            $("#pytanie1").val(ui.value);
        },
        min: 1,
        max: 10

    });
});