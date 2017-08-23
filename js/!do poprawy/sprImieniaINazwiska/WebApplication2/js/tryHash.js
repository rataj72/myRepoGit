$(document).ready(RegistarAllOnLoad);

var validationCallBack = {
    'CustomSurnameValid': CustomSurnameValid
};

function ValidationOtherField(inputFieldId) {
    var input = $('#' + inputFieldId);
    var otherFieldCallBack = input.Attr('data-validation-other-field-id');
    var otherFieldId = input.Attr('data-other-field-id');
        console.log('edit  ' + otherFieldCallBack);
    validationCallBack[otherFieldCallBack](otherFieldId, input.value());
}

function RegistarAllOnLoad() {
    $('#applicationName').blur(function (ev) { ValidationOtherField('applicationName'); });
}

function CustomSurnameValid(fieldId, referenceValue) {
    if (referenceValue == 'bartek') {
        if ($('#'+fieldId).value() == 'zapart') {
            alert("dzialam");
        } else {
            $('#' + fieldId).value('');
        }
    }
}