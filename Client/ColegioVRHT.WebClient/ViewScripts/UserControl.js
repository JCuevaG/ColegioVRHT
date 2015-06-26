

// Inicia un nuevo Popup
function InicioPopup(selector, ancho, alto, resize, titulo) {
    $(selector).dialog({
        autoOpen: false,
        height: alto,
        width: ancho,
        modal: true,
        resizable: resize,
        hide: 'fade',
        show: 'fade',
        title:titulo

    });
}

function JPopupOpen(selector) {
    $(selector).dialog("open");
}


function JPopupClose(selector) {
    $(selector).dialog("close");
}

function JPopupConfirm(selector,ancho,resize,titulo,actionfunction) {
    $(selector).dialog({
        autoOpen: false,
        width: ancho,
        modal: true,
        resizable: resize,
        hide: 'hide',
        show: 'hide',
        title: titulo,
        buttons: {
            "SI": function () {
                if (actionfunction != null) {
                    actionfunction();
                }
                $(selector).dialog("close");
            },
            "NO": function () {
                $(selector).dialog("close");
                return false;
            }
        }
    });
}


function InicioPopupConfirmOpen(selector,ancho,resize,titulo) {
    $(selector).dialog({
        autoOpen: false,
        width: ancho,
        modal: true,
        resizable: resize,
        hide: 'fade',
        show: 'fase',
        title: titulo,
        buttons: {
            "Aceptar": function () {
                $(selector).dialog("close");
            }
        }
    });
}

