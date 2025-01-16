function repeatString(str, n){
    result = '';
    for(let i = 0; i < n; i++){
        result += str;
    }

    return result;
}


//task 2
function formatGrade(grade){
    let formatted = '';
    if(grade < 3.00){
        formatted = 'Fail';
        grade.toFixed(0);
    }else if(grade >= 3.00 && grade < 3.50){
        formatted = 'Poor';
    }else if(grade >= 3.50 && grade < 4.50){
        formatted = 'Good';
    }else if(grade >= 4.50 && grade < 5.50){
        formatted = 'Very good';
    }else if(grade >= 5.50){
        formatted = 'Excellent'
    }
    console.log(`${formatted} (${grade.toFixed(2)})`)
}

formatGrade(2.99)


//task 3
function mathPower(number, power){
    let result = 1;
        for(let i = 0; i < power; i++){
            result = result * number;
        }
    return result;
}
    
    //console.log(mathPower(2, 8));

//task 4
function orders(product, quantity){
    let result = 0.00;
    if(product === 'coffee'){
        result = 1.5 * quantity;
    }else if(product === 'coke'){
        result = 1.4 * quantity;
    }else if(product === 'water'){
        result = 1.0 * quantity
    }else if(product === 'snacks'){
        result = 2.0 * quantity
    }

    return result.toFixed(2);
}
//console.log(orders('water', 5))


//task 5
function simpleCalculator(a, b, operator){
    switch(operator){
        case 'multiply':
        let multiply = (a, b) => a * b;
        console.log(multiply(a, b));
        break;
        case 'divide':
        let divide = (a, b) => a / b;
        console.log(divide(a, b));
        break;
        case 'add':
        let add = (a, b) => a + b;
        console.log(add(a, b));
        break;
        case 'subtract':
        let subtract = (a, b) => a - b;
        console.log(subtract(a, b));
        break;
    }
    
}

//task 5

function signCheck(a, b, c){
    let count = 0;
    if(a <= 0){
        count++;
    }
    if(b <= 0){
        count++;
    }
    if(c <= 0){
        count++;
    }

    if(count & 2 != 0){
        console.log('Negative');
    }else{
        console.log('Positive');
    }
}
signCheck(5, 12, -15)
