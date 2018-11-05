// Write your JavaScript code.

$(document).ready(function() {
    var count = 0;
    $('.bindEvent').click(function(data) {
        changeEvent(data);
    });

    function changeEvent(data) {
        /*console.log(data); */
        count ++;
        document.getElementById("count").innerHTML =  'Confirm(' + count + ')';
    }

});
