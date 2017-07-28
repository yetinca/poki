$(document).ready(function () {
    $(".participant-item").click(function () {
        var id = $(this).attr("data-id");
        location.href = "GetGroups/" + id;
    });
});
