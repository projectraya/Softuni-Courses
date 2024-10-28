function processOldNumbers(array){

    let result = array.filter(x => x % 2 == 1)
    .map(x => x * 2)
    .reverse();

    return result;

}
console.log(processOldNumbers([1, 2, 3, 4, 5])); //10 6 2
