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












