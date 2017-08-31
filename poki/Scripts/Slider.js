$(document).ready(function () {
    $('input[rel="txtTooltip"]').tooltip({
        'selector': '',
        'placement': 'top',
        'container': 'body'
    });   
    //var handle = $("#custom-handle");
    $(".pytanie1").slider({
        create: function (e, ui) {
            $(e.target).find(".custom-handle").text($(this).slider("value"));
            $(e.target).val($(this).slider("value"));
        },
        slide: function (e, ui) {
            $(e.target).find(".custom-handle").text(ui.value);
            $(e.target).val(ui.value);
        },
        min: 1,
        max: 10

    });
    $("#button-save").click(function () {
        var daneDoZapisu = {};
        daneDoZapisu.StartTime = $("#StartTime").val();
        daneDoZapisu.AssessingParticipantID = $("#AssessingParticipantID").val();
        daneDoZapisu.Answers = [];
        $(".data-opis").each(function () {
            var pojOdp = {};
            pojOdp.QuestionID = $(this).attr("data-QuestionId");
            pojOdp.ParticipantInGroupID = $(this).attr("data-ParticipantInGroupID");
            pojOdp.QuestionValue = $(this).find(".custom-handle").text();
            pojOdp.QuestionText = $(this).find("textarea").val();
            daneDoZapisu.Answers.push(pojOdp);
        });
        $.ajax({
            url: "/Tests/SaveTest1",
            data: JSON.stringify(daneDoZapisu),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            type: "POST",
            success: function (result) {


            },
            error: function (xhr, ajaxOptions, thrownError) {

            }
        });

    });
});