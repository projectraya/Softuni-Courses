function printCharacters(input){

    for(let ch of input){
        console.log(ch);
    }
}

function substring(text, index, count){
    let result = text.substring(index, index + count);
    console.log(result);
}

//substring('ASentance', 1, 8)

function censoredWords(text, word){
    while(text.includes(word)){
        text = text.replace(word, '*'.repeat(word.length))
    }
    console.log(text);
}

censoredWords('A small sentence with some word', 'small')

function countStringOccurances(text, search){
    let words = text.split(' ');
    let counter = 0;
    for(let word of words){
        if(word == search){
            counter++;
        }
    }
    console.log(counter)
}