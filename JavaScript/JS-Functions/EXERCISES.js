//task 1
function smallestNumber(a, b, c){
let smallest = 0;
if(a < b){
    smallest = a;
    if(a < c){
        smallest = a;
    }else{
        smallest = c;
    }
}else{
    if(b < c){
        smallest = b;
    }else{
        smallest = c;
    }
}
return console.log(smallest);
}
//task 2

function addAndSubtract(a, b, c){
    function add(a, b){
        let result = a + b;
        return result;
        
    }
    let result = add(a, b);

    function subtract(result, c){
        let answer = result - c;
        return answer;
    }

    let answer = subtract(result, c);
    console.log(answer);
}

//addAndSubtract(1, 17, 30);

//task 3
function charactersInRange(one, two){

    one = one.charCodeAt();
    two = two.charCodeAt();
    let collection = [];
    if(one < two){
        for(let i = one + 1; i < two; i++){
            let answer = String.fromCharCode(i);
            collection.push(answer);
        }
    }else{
        for(let i = two + 1; i < one; i++){
            let answer = String.fromCharCode(i);
            collection.push(answer);
        }
    }
    
    console.log(collection.join(" "));
}
//charactersInRange('#', ':');

//task 4
function oddAndEvenSum(number){
    let array = number.toString().split("").map(Number);
    let oddSum = 0;
    let evenSum = 0;

    for(let i = 0; i < array.length; i++){
        if(array[i] % 2 == 0){
            evenSum += array[i];
        }else{
            oddSum += array[i];
        }
    }
    
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}
//oddAndEvenSum(1000435);

//task 5
function palindromeIntegers(array){
    
    for(let i = 0; i < array.length; i++){
        console.log(isPalindrome(array[i]));
        
    }
    function isPalindrome(num){
        let reversedNum = num.toString().split('').reverse().join('')
        if(num === Number(reversedNum)){
            return 'true';
        }else{
            return 'false';
        }
        
    }
}
//palindromeIntegers([123,323,421,121]);

//task password shits
function passwordValidator(password) {
    let isValid = true;

    // Check length
    if (password.length < 6 || password.length > 10) {
        isValid = false;
        console.log('Password must be between 6 and 10 characters');
    }

    // Check for at least 2 digits
    const digitCount = password.replace(/[^0-9]/g, "").length;
    if (digitCount < 2) {
        isValid = false;
        console.log('Password must have at least 2 digits');
    }

    // Check for letters and digits only
    if (!/^[A-Za-z0-9]*$/.test(password)) {
        isValid = false;
        console.log('Password must consist only of letters and digits');
    }

    if (isValid) {
        console.log('Password is valid');
    }
}

//passwordValidator('MyPass123');

//task 7
function NxNMatrix(number){
    let line = [];
    for(let i = 0; i < number; i++){
        for(let j = 0; j < number; j++){
            line.push(number);
            
        }
        console.log(line.join(" "));
        line = [];
    }
}
//NxNMatrix(3);

function perfectNumber(number){
    let collection = [];
    let sum = 0;
    if(number > 0){
        for(let i = 0; i < number; i++){
            if(number % i == 0){
                collection.push(i);
            }
        }

        for(let j = 0; j < collection.length; j++){
            sum += collection[j];
        }
        if(sum == number){
            console.log('We have a perfect number!');
        }else{
            console.log('It\'s not so perfect.')
        }

    }else{
        console.log('It\'s not so perfect.')
    }
}