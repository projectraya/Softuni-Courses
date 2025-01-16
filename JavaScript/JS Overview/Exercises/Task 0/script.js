function add() {
    getResult("add");
}

function subtract() {
    getResult("subtract");
}

function multiply() {
    getResult("multiply");
}

function divide() {
    getResult("divide");
}
function getResult(operation) {
    const num1 = parseFloat(document.getElementById('num1').value);
    const num2 = parseFloat(document.getElementById('num2').value);
    let result;

    switch (operation) {
        case "add":
            result = num1 + num2;
            break;
        case "subtract":
            result = num1 - num2;
            break;
        case "multiply":
            result = num1 * num2;
            break;
        case "divide":
            result = num2 !== 0 ? num1 / num2 : "Cannot divide by zero";
            break;
        default:
            result = "Invalid operation";
    }
    document.getElementById('result').innerText = `Result: ${result}`;
}
