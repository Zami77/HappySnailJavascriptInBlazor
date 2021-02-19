function PrintTextBox(elemId) {
    var text = document.getElementById(elemId).value;
    if (text === "") {
        text = "You have to put something in the text box!";
    }
    alert(text);
}
