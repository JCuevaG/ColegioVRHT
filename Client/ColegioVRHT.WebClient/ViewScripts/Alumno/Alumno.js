(function () {
    $(document).ready(function () {
        $("#modal").click(modal);
        
        

    });

    var modal = function () {
        $.ajax({
            url: UrlAction.Create,
            type: "GET",
            success: function(data){
                $("#modalito").html(data);
                $("#modalito").dialog({
                    modal: true,
                    width: 1170,
                    height: 600,
                    title:'Mantenimiento'
                    
                    //Creando el boton cancelar del modal
                    //buttons: {
                    //    Cancelar: function () {
                    //        $(this).dialog("close")
                    //    }
                    //}
                })

                $("#modalito").find("#btnCrear").click(GrabarAlumno);
            },
            complete: function () {
                $("#FechaNacimiento").datepicker();
                $("#FechaNacimiento").datepicker("option", "showAnim", "show");
            }
        })
    }



    var GrabarAlumno = function () {
        var idFormularioAlumno = $("#IdFormularioCreateAlumno");
        $.ajax({
            url: UrlAction.Create,
            type: "POST",
            data: idFormularioAlumno.serialize(),
            success: function (data) {
                toastr["success"](data)
            }
        })
    }
    

})()