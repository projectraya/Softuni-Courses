function amazingNumbers(num){
    let sum = 0;
    let string = num.toString();
    let arr = Array.from(string);

   for(i = 0; i < arr.length; i++){
        sum += parseInt(arr[i]);
   }
   
    if(sum === 9){
        console.log(`True`);
    }else{
        console.log(`False`);
    }
}

amazingNumbers(522);