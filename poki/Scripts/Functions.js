$(document).ready(function () {
    $(".participant-item").click(function () {
        var id = $(this).closest("tr").attr("data-id");
        location.href = "GroupsWithDetails/" + id;
    });

    $(".group-participants").click(function () {
        var id = $(this).attr("data-id");
        location.href = "../ParticipantsInGroup/" + id;
    });

 

});