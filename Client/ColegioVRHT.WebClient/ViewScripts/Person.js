

    
   
    function createperson() {
        form = $('#IdFrmPersona')
        $.ajax
            ({
                url: UrlAction.URLPerson,
                type: 'POST',
                data: form.serialize(),
                
                success: function (data) {
                    toastr["success"](data);
                }

            
            })
    }


