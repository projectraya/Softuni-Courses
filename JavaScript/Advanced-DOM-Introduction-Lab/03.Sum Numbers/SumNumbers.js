function calc() {
    // TODO: sum = num1 + num2
    let num1 = document.getElementById("num1").value;
    let num2 = document.getElementById("num2").value;
    const operator = document.getElementById('operator').value;

    let result;
    let num1AsNumber = Number(num1);
    let num2AsNumber = Number(num2);

    if(operator == '+'){
        result = num1AsNumber + num2AsNumber;
        
    }
    else if (operator == '-'){
        result = num1AsNumber - num2AsNumber;

    }
    else if (operator == '*'){
        result = num1AsNumber * num2AsNumber;

    }
    else if (operator == '/'){
        result = num1AsNumber / num2AsNumber;

    }
    document.getElementById('sum').textContent = result;

}