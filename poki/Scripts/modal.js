$(document).ready(function () {
$("#input-pesel").click(function () {
 
    var groupID=  $("#GroupID").val();
    var pesel = $("#pesel").val();

     //$("#modalPesel").modal('hide');

    $.ajax({
        url: "/Home/ValidatePESEL",
        data: JSON.stringify({pesel:pesel,groupID:groupID}),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        type: "POST",
        success: function (result) {
            if (result == 0) {
                alert("niepoprawny PESEL")
            }
            else {
                location.href = "/Tests/Test1/" + result;
            }

        },
        error: function (xhr, ajaxOptions, thrownError) {

        }
    });
});

});