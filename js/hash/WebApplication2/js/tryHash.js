function takeOne() {
    alert("zyje");
}

takeOne();

function doHash() {
    var h = new Object(); // or just {}
    h['one'] = 1;
    h['two'] = 2;
    h['three'] = 3;

    // show the values stored
    for (var k in h) {
        // use hasOwnProperty to filter out keys from the Object.prototype
        if (h.hasOwnProperty(k)) {
            alert('key is: ' + k + ', value is: ' + h[k]);
        }
    }
}

//doHash();

function writeMe() {
    var lista = Array();
    lista.push("dsa");
    lista.push("dsa23532");
    lista.push("dsahaedr");
    lista.push("dsaasf");

    for (var i = 0; i < lista.length; i++) {
        document.writeln("item w liscie " + lista[i] + "<br>");
    }

}

writeMe();