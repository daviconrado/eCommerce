$("#discovery").click(function() {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#products").offset().top
    }, 2000);
});

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});

$("#btn-discovery").click(function () {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#products").offset().top
    }, 2000);
});
function urlContainsLogin() {
    const currentUrl = window.location.href;
    return currentUrl.includes("Login");
}
$(document).ready(function () {
    if (urlContainsLogin()) {
        const navbar = $("#navbar");

        navbar.removeClass("position-fixed").addClass("position-static");
    }
});
