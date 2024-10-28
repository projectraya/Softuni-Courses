function movie(input) {
    let maxPoints = -Infinity; 
    let finalMovie = '';
    
   
    if (input.length >= 7) {
        console.log(`The title limit has been transferred.`);
    }

    for (let i = 0; i < input.length; i++) {
        let currentMovie = input[i];
        let points = 0;  

        
        for (let j = 0; j < currentMovie.length; j++) {
            let currentChar = currentMovie[j];
            let currentCharAsPoints = currentChar.charCodeAt(0); 
            points += currentCharAsPoints;

            
            if (currentChar >= 'a' && currentChar <= 'z') { 
                points -= (currentMovie.length * 2);
            } else if (currentChar >= 'A' && currentChar <= 'Z') { 
                points -= currentMovie.length;
            }
        }

        
        if (points > maxPoints) {
            maxPoints = points;
            finalMovie = currentMovie;
        }
    }
      
    
    console.log(`The movie tonight is ${finalMovie} collected points: ${maxPoints}`);
}


movie(['Django Unchained', 'Joker', 'Oldboy', 'Hamilton', 'Klaus', 'Inside Out', 'Prisoners']);
