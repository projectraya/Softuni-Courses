function solve() {

    const button = document.querySelector('button');
    const selectMenuTo = document.getElementById('selectMenuTo');
    
    let binaryElement = document.createElement('option');
    binaryElement.textContent = "Binary";
    binaryElement.value = 'binary';
    selectMenuTo.appendChild(binaryElement);

    let hexElement = document.createElement('option');
    hexElement.textContent = "Hexadecimal";
    hexElement.value = 'hexadecimal';
    selectMenuTo.appendChild(hexElement);

    button.addEventListener('click', convert)
}

function convert(){
    
    let input = document.querySelector("#input");
    let result = document.querySelector("#result");
    let desiredType = document.querySelector("#selectMenuTo");

    let inputAsNum =Number(input.value);

    if(desiredType.value == "binary"){

        result.value = inputAsNum.toString(2);
        console.log('binary has entered')
        console.log(result)
        
    }
    else if(desiredType.value == "hexadecimal"){

        result.value = inputAsNum.toString(16).toUpperCase();
        console.log('hex has entered')
        console.log(result)
    }
    
}