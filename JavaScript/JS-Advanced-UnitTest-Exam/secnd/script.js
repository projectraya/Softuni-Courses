let solution = {

    multiply: function(array, integer){

        let resultArray = [];
        for(let num of array){

            let resultNum = num * integer;
            resultArray.push(resultNum);
        }

        return console.log(resultArray);
    },
    multiswap: function(array1, array2){

        let firstSum = 0;
        let secondSum = 0;

        firstSum = array1[0] * array2[1];
        secondSum = array1[1] * array2[0];

        return console.log(firstSum - secondSum);
        
    }
}

solution.multiply([3.5, -2], 2);
solution.multiswap([3, 7], [1, 0]);