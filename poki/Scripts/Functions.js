$(document).ready(function () {
    $(".participant-item").click(function () {
        var id = $(this).attr("data-id");
        location.href = "GroupsWithDetails/" + id;
    });
});
$(document).ready(function () {
    $(".group-participants").click(function () {
        var id = $(this).attr("data-id");
        location.href = "GroupsWithDetails/" + id;
    });
});