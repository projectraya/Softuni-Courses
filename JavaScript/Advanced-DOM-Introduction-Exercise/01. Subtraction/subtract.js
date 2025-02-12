function subtract() {
    let firstNum = document.getElementById("firstNumber").value;
    let secondNum = document.getElementById("secondNumber").value;

    let numOne = Number(firstNum);
    let numTwo = Number(secondNum);

    let sum = numOne - numTwo;

    document.getElementById("result").textContent = sum;
}