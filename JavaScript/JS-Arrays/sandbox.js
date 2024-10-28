let arr = [];
arr[3.4] = 'Oranges';
arr[-1] = 'Apples';
console.log(arr.length); //0
console.log(arr.hasOwnProperty(3.4)); //true

arr["1"] = 'Grapes';
console.log(arr.length); //2
console.log(arr);