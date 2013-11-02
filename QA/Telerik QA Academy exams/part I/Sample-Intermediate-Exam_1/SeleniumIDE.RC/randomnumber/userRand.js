function getPre()
{
var i = document.getElementsByClassName('data')[1].innerHTML;
return i;
}


function preTag()
{
var p = document.getElementsByTagName("pre")[0];
return p.childNodes[1].textContent;
}


function getMe()
{
var a = document.getElementsByTagName('pre')[0].textContent;
return a;
}
