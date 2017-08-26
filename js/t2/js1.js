/*function changeText(object) {
    //document.writeln("cos");
    //var a = this.object.innerText;
    alert("a");
    var a = document.getElementById("myI").;
    var b = document.getElementById("myTextBox");
    alert(a);
    b.innerText = a;

}*/
function f1() {
    var tab = ['ala',3, "text"];
    document.writeln(tab);
    for (var i = 0; i < 6; i++) {
        tab.push(i);
    }
    document.writeln(tab);

}

function testSwitcha(param) {
    switch (param) {
        case 1:
            alert("wpisales 1"); break;
        case 2:
            alert("wpisales 2"); break;
        case 3:
            alert("wpisales 3"); break;
        case 4:
            alert("wpisales 4"); break;
        
        default:
            alert("wpisales cos innego"); break;
    }
}

function calculate() {
    var argLength = arguments.length;

    if (argLength == 0) {
        console.warn('Błąd: Nie podałeś żadnych liczb');
    } else if (argLength == 1) {
        console.warn('Podałeś tylko jedną liczbę:' + arguments[0]);
    } else {
        var result = 0;
        for (i in arguments) {
            result += arguments[i];
        }
        console.log(result);
    }
}

function blad() {
    var arg = arguments.length;

    if (arg > 1) {
        var result = 0;
        for (var i = 0; i < arg; i++) {
            result += arguments[i];
            document.writeln(arguments[i]);
        }
        alert(typeof result);
    }
}