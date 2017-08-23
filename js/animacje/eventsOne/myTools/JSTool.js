function myTime() {
   
    var itemOne = document.getElementById('first');
    itemOne.addEventListener('mouseout', function () { this.value = "dziala";  document.getElementById('th').value = liczba;   liczba += 5;});
    itemOne.addEventListener('mouseover', function() { this.value = "" });
    itemOne.addEventListener('keyup', function() {

        document.getElementById('sec').value = document.getElementById('first').value;
    });
}

document.addEventListener("DOMContentLoaded",myTime);

var liczba = 0;

/////////////////
function AddNode(container, chilldNode) {
    var node = document.getElementById(container);
    node.appendChild(generate(chilldNode));
    
}

function generate(el) {
    
    var a = document.createElement(el);
    a.style = 'height: 50px; width: 50px';
    
    return a;
}

var goMy = 5;
var kierunek = 1;

function changePosition() {
    var a = document.getElementById('1');
    a.style = 'margin: ' + goMy + 'px ;' + 'opacity: ' + goMy / 200;

    goMy += 5 * kierunek;

    if (goMy > 100 || goMy <= 0) {

        kierunek *= -1;

    }
}

function powtorz() {
    var i = setInterval(changePosition, 100, 'z inter');
}

powtorz();











