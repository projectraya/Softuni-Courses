function winningCard(inputCard) {
    
    let regex = /([&*%#])\1{5,}/; 
    let validSymbols = ['&', '*', '%', '#'];

   
    if (inputCard.length !== 20) {
        console.log("Invalid Bingo Card");
        return;
    }

    let leftHalf = inputCard.substring(0, 10);
    let rightHalf = inputCard.substring(10, 20);

    
    let matchLeft = leftHalf.match(regex);
    let matchRight = rightHalf.match(regex);

    if (matchLeft && matchRight) {
        let [symbolLeft, lengthLeft] = [matchLeft[0].charAt(0), matchLeft[0].length];
        let [symbolRight, lengthRight] = [matchRight[0].charAt(0), matchRight[0].length];


        
        if (symbolLeft === symbolRight) {
            let matchSymbol = symbolLeft;
            let matchLength = Math.min(lengthLeft, lengthRight);

            if (matchLength === 10) {
                console.log(`Bingo! "${inputCard}" - ${matchLength} simbols: ${matchSymbol}`);
            } else if (matchLength >= 6) {
                console.log(`Card has won a Line "${inputCard}" - ${matchLength} simbols: ${matchSymbol}`);
            }
            return;
        }
    }

    
    console.log(`Card "${inputCard}" - doesn't win`);
}


winningCard('Bing&&&&&&Oo&&&&&&ye'); 
winningCard('&&&&&&&&&&&&&&&&&&&&'); 
winningCard('dgsa'); 
winningCard('skdhagsdncpotwnufmla'); 
