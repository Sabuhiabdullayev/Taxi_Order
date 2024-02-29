$(document).ready(function () {
    $("#btnContactAdd").click(function () {
        $("#btnContactAdd").attr("disabled", "true");
        $("#btnContactAdd").html("Göndərilir...");
        var date = (new Date()).toISOString().split('T')[0];
        let contact = {
            Name: $("#Name").val(),
            Email: $("#Email").val(),
            Subject: $("#Subject").val(),
            Content: $("#Content").val(),
            Date: date
        };
        $.ajax({
            type: "post",
            url: "/ContactUs/Contact/",
            data: contact,
            success: function (func) {


                Swal.fire({
                    title: "Mesajınız göndərildi!",
                    text: "Mesajınıza ən qısa zaman içində baxçlacaqdır!",
                    icon: "success"
                });
                $("#btnContactAdd").attr("disabled", false);
                $("#btnContactAdd").html("Mesajınızı Göndərin");
                $("#Name").val("");
                $("#Email").val("");
                $("#Subject").val("");
                $("#Content").val("");
            }
        });
    });
});