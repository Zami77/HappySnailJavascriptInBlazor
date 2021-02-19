function PrintTextBox(docId) {
    var text = document.getElementById(docId).value;
    if (text === "") {
        text = "You have to put something in the text box!";
    }
    alert(text);
}