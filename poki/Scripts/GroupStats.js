$(document).ready(function () {
    $.ajax({
        url: "/Tests/GetGroupStats",
        data: JSON.stringify({
            participantInGroupID: $("#participantInGroupID").val()}),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        type: "POST",
        success: function (result) {
            if (result != null) {
                var barChartData = {
                    labels: result.Labels,
                    datasets: [{
                        label: 'Ocena własna',
                        backgroundColor:
                        'rgba(215, 135, 44, 0.9)',

                        data: result.OcenaWlasna
                    }, {
                        label: 'Ocena Grupy',
                        backgroundColor:
                        'rgba(102, 135, 44, 0.9)',

                        //yAxisID: "y-axis-2",
                        data: result.OcenaGrupy
                    }]
                };





                var ctx = document.getElementById("canvas").getContext("2d");
                window.myBar = new Chart(ctx, {
                    type: 'bar',
                    data: barChartData,
                    options: {
                        responsive: true,
                        title: {
                            display: true,
                            text: "Wykres Ocen"
                        },
                        tooltips: {
                            mode: 'index',
                            intersect: true
                        },
                        scales: {
                            yAxes: [{

                                ticks: {
                                    beginAtZero: true
                                }
                            },
                            ],
                        }
                    }
                });
            }
            else {
                location.href = "/Tests/Test1/" + result;
            }

        },
        error: function (xhr, ajaxOptions, thrownError) {

        }
    });

    

});