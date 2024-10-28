function cinema(type, row, col){
let income = 0;

if(type == "Premiere"){
    type = 12.00;
    income = row * col * type;

}else if(type == "Normal"){
    type = 7.50;
    income = row * col * type;

}else if(type == "Discount"){
    type = 5.00;
    income = row * col * type;
}

console.log(`${income.toFixed(2)} leva`)
}