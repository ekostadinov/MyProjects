$("header nav ul").css("list-style-type", "none");
$("header nav ul li").css("display", "inline");
$("header nav ul li a").css("text-decoration", "underline");
$("header nav ul li a").css("color", "white");
$("header nav ul li a").css("font-size", "1.6em");
$("header nav ul li").hover(function NavUlLiA() {
    $('<h4>Your navigation menu:</h4>')
        .hide().prependTo('header nav ul').slideDown('slow');
    $("header nav ul li a").css("background-color", "#B37638");
}, function NavUlLiABack() {
    $("header nav ul li a").css("background-color", "#3aafbb");
    $('header nav h4').remove('header nav h4');
});

$("ul li ul a").css("font-size", "1em");
$(".igdt_NodeGroup").css("font-size", "1.5em");