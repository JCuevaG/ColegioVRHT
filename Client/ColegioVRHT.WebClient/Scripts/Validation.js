(function ($) {
    $.fn.isValidForm = function () {
        var valid = true,
           $form = this;

        $form.find('input,select,textarea').each(function (index, elem) {
            var item = $(elem).hasClass('ignorefield');
            if (!item) {
                var isElemValid = $form.validate().element($(this));
                if (isElemValid != null) {
                    valid = valid & isElemValid;
                    if (valid == false)
                        console.log($(this));
                }
            }
        });

        return valid;
    },

    $.fn.addValidattionForm = function () {
        var form = this.closest("form");
        form.removeData('validator');
        form.removeData('unobtrusiveValidation');
        $.validator.unobtrusive.parse(form);
    }

})(jQuery)