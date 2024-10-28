function rightPlace(firstString, symbol, secondString){
    
    let count = 0;
    firstString = firstString.split('');
    firstString.forEach(element => {
        if(element == '_'){
            firstString[count] = symbol;
            console.log(firstString);
        }
        count++;
    });

    let wow = firstString.join("");
    
    if(wow == secondString){
        console.log('Matched');
    }else{
        console.log('Not Matched');
    }
}

rightPlace('Str_ng', 'I', 'StrIng')
