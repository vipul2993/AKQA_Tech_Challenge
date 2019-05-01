$(document).ready(function () {

    $("#btnConvert").on("click", function () {
        convertNumberToWords($("#txtNumber").val());
    });


    var convertNumberToWords = function (number) {
        var data = { number: number };
        $.ajax({
            url: "/api/convert?number=" + number,
            data: JSON.stringify(data),
            type: "Post",
            success: function (result) {
                $("#nameOfPerson").html($("#txtPersonName").val());
                $("#words").html(result);
            },
            error:function(err)
            {
                console.log(err);
            }
        });

      
    }


});