$(document).ready(function () {
    $('.btnNext').click(function () {
        $('.nav-tabs > .active').next('li').trigger('click');
    });

    $('.btnPrevious').click(function () {
        $('.nav-tabs > .active').prev('li').trigger('click');
    });
})