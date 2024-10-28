function movie(input){
    let maxPoints = -Infinity;
    let finalMovie = '';
    
    if(input.length >= 7){
        console.log(`The title limit has been transferred.`);
        
    }

    for(let i = 0; i < input.length; i++){
        
        let currentMovie = input[i]; 
        let points = 0;

        for(let j = 0; j < currentMovie.length; j++){

            let currentChar = currentMovie[j];
            let currentCharNumber = currentChar.charCodeAt(0);
            points += currentCharNumber;
            
            if(currentChar === currentChar.toLowerCase()){

                points -= (currentMovie.length * 2);  
            }else{

                points -= currentMovie.length;
            }
            
        }

        if(points > maxPoints){
            maxPoints = points;
            finalMovie = currentMovie;
        }
    }
      
    console.log(`The movie tonight is ${finalMovie} collected points: ${maxPoints}`);
}


movie(['Amadeus', 'The Hurt Locker', 'The Godfather', 'Se7en'])