function sumFirstAndLast(array){
    let last = array.pop();
    let first = array.shift();
    let sum = first + last;
    return sum;
}

console.log(sumFirstAndLast([1, 2, 3, 4, 5]));

