(function () {
    $(document).ready(function () {
        $("#modal").click(modal);
        InicioPopup("#modalito", 1170, 600, false, 'Mantenimiento');
        

    });

    var modal = function () {
        $.ajax({
            url: UrlAction.Create,
            type: "GET",
            success: function (data) {
                $("#modalito").html(data);
                JPopupOpen("#modalito")
                $("#modalito").find("#btnCrear").click(GrabarAlumno);
            },
            complete: function () {
                $("#FechaNacimiento").datepicker();
                $("#FechaNacimiento").datepicker("option", "showAnim", "show");
                $("#IdFormularioCreateAlumno").addValidattionForm();
            }
        })
    }



    var GrabarAlumno = function () {
        var idFormularioAlumno = $("#IdFormularioCreateAlumno");
        if (idFormularioAlumno.isValidForm()) {
            $.ajax({
                url: UrlAction.Create,
                type: "POST",
                data: idFormularioAlumno.serialize(),
                success: function (data) {
                    debugger;
                    var mensaje = data.split('-');
                    if (mensaje[1] == 1)
                        toastr["success"](mensaje[0].toString())
                    else
                        toastr["error"](mensaje[0].toString())
                }
            });
        }     
    }
    

})()