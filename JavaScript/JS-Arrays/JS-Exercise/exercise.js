function addAndSubtract(array){
        //let oddArray = array.filter(x => x % 2 == 0).map(x => x + indexOf(x));
        //let evenArray = array.filter(x => x % 2 == 1).map(x => x - indexOf(x));

        let sum = 0;
        let newArr = [];
        for (let i = 0; i < array.length; i++ ) {
            sum += array[i];
            array[i] % 2 == 0 ? newArr.push(array[i] + i) : newArr.push(array[i] - i);
        }

        console.log(newArr); //modified array
        console.log(sum); //sum numbers of original array

        let modSum = 0;
        for (let i = 0; i < array.length; i++ ) {
            modSum += newArr[i];
        }
        console.log(modSum); //sum numbers from modified array

}


//addAndSubtract([1, 2, 3, 4, 5, 6]);

function commonElements(arrayOne, arrayTwo){
    let commonOne = '';
    let commonTwo = '';

    for(let i = 0; i < arrayOne.length; i++){
        for(let j = 0; j < arrayTwo.length; j++){

            if(arrayOne[i] === arrayTwo[j]){
                if(commonOne == ''){
                    commonOne = arrayOne[i];
                }
                else{
                    commonTwo = arrayOne[i];
                }
                
            }
            
        }
    }
    console.log(commonOne);
    console.log(commonTwo);

}

function commonElementsBetter(arrayOne, arrayTwo) {
    // Filter to get common elements between the two arrays
    const common = arrayOne.filter(element => arrayTwo.includes(element));

    // Slice the result to get only the first two common elements
    const firstTwoCommon = common.slice(0, 2);

    // Print the first two common elements
    console.log(firstTwoCommon[0]); 
    console.log(firstTwoCommon[1]); 
}

//commonElements(['Hey', 'hello', 2, 4, 'Peter', 'e'], ['Petar', 10, 'hey', 4, 'hello', 2]);

function mergeArrays(arrayOne, arrayTwo){
    let newArray = [];
    for(let i = 0; i < arrayOne.length; i++){
        i % 2 == 0 ? newArray.push(Number(arrayOne[i]) + Number(arrayTwo[i])) : newArray.push(arrayOne[i] + arrayTwo[i]);
    }

    console.log(newArray.join(' - '));
}
//ergeArrays(['5', '15', '23', '56', '35'], ['17', '22', '87', '36', '11']);

function arrayRotation(array, number){
    for(let i = 0; i < number; i++){
        array.push(array.shift());
    }
    console.log(array.join(' '));
}
//arrayRotation([51, 47, 32, 61, 21], 2)

function distinctArray(numbers){
    newArr = [];
    for(let i = 0; i < numbers.length; i++){
        
        newArr.push(numbers[i]); //put 7 in new array
        for(let j = 0; j < newArr; j++){ //see all elements in new array
            if(numbers[i] == newArr[j]){
                newArr.unshift();
            }
        }
    }

    console.log(newArr);
}
distinctArray([7, 8, 9, 7, 2, 3, 4, 1, 2])
    