$(document).ready(function () {
    $(".row").on('click', "li #delete", function () {
        var deletebtn = $(this);
        var deleteid = deletebtn.data("id");
        const swalWithBootstrapButtons = Swal.mixin({
            customClass: {
                confirmButton: "btn btn-success",
                cancelButton: "btn btn-danger"
            },
            buttonsStyling: false
        });
        swalWithBootstrapButtons.fire({
            title: "Elanı siləcəkmisiniz?",
            text: "Bunu geriyə qaytara bilməyəcəksiniz!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Bəli, Silin!",
            cancelButtonText: "Xeyir, Ləğv Edin!",
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: "delete",
                    dataType: "json",
                    url: "/Member/Order/Delete/" + deleteid,
                    success: function (func) {
                        swalWithBootstrapButtons.fire({
                            title: "Silindi!",
                            text: "Elan silindi.",
                            icon: "success"
                        });
                        deletebtn.parent().parent().parent().parent().remove();
                    }
                });

            } else if (
                /* Read more about handling dismissals below */
                result.dismiss === Swal.DismissReason.cancel
            ) {
                swalWithBootstrapButtons.fire({
                    title: "Ləğv edildi",
                    text: "Elan silinmə ləğv olundu :)",
                    icon: "error"
                });
            }
        });
    });
});

