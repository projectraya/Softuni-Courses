function revealWords(words, sentence){
    

}

//revealWords('great, learning', 'softuni is ***** place for ******** new programming languages')

function modernTimes(sentence){

    sentence = sentence.split(" ");
    let result = 0;
    for(let word of sentence){
        if(word[0] == '#' && word.length > 1){

            for(let i = 1; i < word.length; i++){
                
                let char = word[i].charCodeAt(0);
                if((char >= 65 && char <= 90) || (char >= 97 && char <= 122)){
                    result++;
                }
               
            
            }
            if(result == word.length - 1){
                console.log(word.slice(1, word.length))
                result = '';
            }
            
        }
        
    }
}

//modernTimes('Nowadays everyone uses # to tag a #spec8ial word in #socialMedia')

function passwordGenerator(input){
    const [first, second, third] = input;
    let comb = first.concat(second).split('');
    const vowels = ['a', 'e', 'o', 'i', 'u'];
    let thirdIndex = 0;
    const letterSequence = third.toUpperCase().split(''); // ['o', 'r', 'a', 'n', 'g', 'e']
    
    for(let i = 0; i < comb.length; i++){
        if(vowels.includes(comb[i])){
            
            if(thirdIndex > letterSequence.length - 1){
                thirdIndex = 0;
                
            }
            comb[i] = letterSequence[thirdIndex];
            thirdIndex++;
        }
        
    }
    console.log(`Your generated password is ${comb.reverse().join('')}`);
    
}

passwordGenerator(['ilovepizza', 'ihatevegetables', 'orange'])

// let example = ('sElbGtNgAvRtOhEGzzNpAvRlO').split('');
//     example = example.reverse();
//     let joinArr = example.join("")
//     console.log(joinArr);