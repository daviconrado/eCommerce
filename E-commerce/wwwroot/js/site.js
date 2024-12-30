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
function urlContainsAboutMe() {
    const currentUrl = window.location.href;
    return currentUrl.includes("AboutMe");
}

$(document).ready(function () {
    if (urlContainsLogin()) {
        const navbar = $("#navbar");

        navbar.removeClass("position-fixed").addClass("position-static");
    }

    if (urlContainsAboutMe()) {
        const navbar = $("#navbar");

        navbar.removeClass("position-fixed").addClass("position-static");
    }
});



const collapseElement = $("#navbarToggle");
const parentElement = $("#navbarItems");

collapseElement.on('shown.bs.collapse', () => {
    parentElement.removeClass("gap-5").addClass("gap-0");
});

collapseElement.on('hidden.bs.collapse', () => {
    parentElement.removeClass("gap-0").addClass("gap-5");
});