function dayOfWeek(number){
    if(number < 1 || number > 7){
        if(number % 1 == 0){
            console.log('Invalid day!');
            return;
        }
        
    }
    let arr = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];

    console.log(arr[number - 1]);
}

dayOfWeek(1);