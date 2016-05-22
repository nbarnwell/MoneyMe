$(document).ready(function() {
    var now = moment();
    $("#TransactionTime").val(now.format('L') + ' ' + now.format('HH:mm'));
});