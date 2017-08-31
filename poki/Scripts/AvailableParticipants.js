$(document).ready(function () {
    $("#zapisz-do-grupy").click(function () {
        var grID = $("#plusik").attr("data-grupa");
        var daneDoZapisu = {}
        $('#Persons tr').each(function () {
            $(this).find('#plusik value:false').each(function () {

                daneDoZapisu.groupID = $("#plusik").attr("data-grupa");
                daneDoZapisu.participantID = $("#data_id").val();

            });
        });
        $.ajax({
            url: "/Home/AddParticipantToGroup/",
            data: JSON.stringify(daneDoZapisu),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            type: "POST",
            success: function (result) {
               
                    if (result == null) {
                        alert("Wybierz osoby")
                    }
                    else {
                        location.href = "/Home/ParticipantsInGroup/" + grID;
                    }

            },
            error: function (xhr, ajaxOptions, thrownError) {

            }
        });
    });

   
 

});