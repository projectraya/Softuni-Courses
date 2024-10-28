function calculator(a, operator, b){

    a = Number(a);
    b = Number(b);

    switch(operator){
        case("+"):
        return console.log((a + b).toFixed(2)); break;
        case("-"):
        return console.log((a - b).toFixed(2)); break;
        case("*"):
        return console.log((a * b).toFixed(2)); break;
        case("/"):
        return console.log((a / b).toFixed(2)); break;
        
    }
}

calculator(5, "+", 4);