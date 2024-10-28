function negativeOrPositive(numbers){
    let ot = [];
    for(let i = 0; i < numbers.Length; i++){
        if(numbers[i] < 0){
            ot.unshift(numbers[i])
        }else{
            ot.push(numbers[i]);
        }
    }
    console.log(ot.join(`\n`));
}

negativeOrPositive([7, -2, 8, 9]); 

//FIX THIS