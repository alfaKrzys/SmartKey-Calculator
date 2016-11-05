$(function () {
    jQuery.validator.addMethod('validzeroinkey', function (value, element, params) {
        if((value.length==9 && value.charAt(0) == '0') || (value.length == 8 && value.charAt(0) != '0'))
            return true;
        else
            return false;
    }, '');
jQuery.validator.unobtrusive.adapters.add('validzeroinkey', function (options) {
    options.rules['validzeroinkey'] = {};
    options.messages['validzeroinkey'] = options.message;
});
}(jQuery));