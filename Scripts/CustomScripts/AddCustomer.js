$(document).ready(function () {
    $("#divupi").hide();
    $("#divcheque").hide();
    $("#ismember").hide();
    $("#PAYMODE").on("change", function () {
        $("#divupi").hide();
        $("#divcheque").hide();
        if (this.value == 'UPI') {
            $("#divupi").show();
        }
        else if (this.value == 'CHEQUE') {
            $("#divcheque").show();
        }
        else {
            $("#divupi").hide();
            $("#divcheque").hide();
        }

    })
    $("#ISMEMBER").on("change", function () {
        if ($("#ISMEMBER").prop("checked") == true) {
            $("#ismember").show();
        }
        else
        {
            $("#ismember").hide();
        }
    })
})