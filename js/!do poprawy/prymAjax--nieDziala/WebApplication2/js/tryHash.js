function pobierz() {
    $.ajax({
            url: 'random.txt',
            success: function(data) {
                document.getElementById('jeden').innerHTML = data;
            }
        }
    );
}