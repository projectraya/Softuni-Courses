function sumTwoNumbers(start, end, magicNum){
    let sum = 0;
    start = Number(start);
    end = Number(end);
    magicNum = Number(magicNum);

    for(let i = start; i < end; i++){
        for(let j = start; j < end; j++){

            sum = i + j;
            if(sum === magicNum){
                console.log(`Number found! ${sum} = ${magicNum}`)
            }
        }
    }

}