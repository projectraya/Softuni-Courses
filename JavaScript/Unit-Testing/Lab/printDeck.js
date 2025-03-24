const res = require("express/lib/response");

function printDeckOfCards(cards){

    function createCard(face, suit){

        const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
        const validSuits = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663'
        }
        if(!validFaces.includes(face) || !Object.keys(validSuits).includes(suit))
        {
            throw new Error('Error');

        }
        return {
            face, suit, toString(){
                return `${face}${validSuits[suit]}`
            }
        }
    }

    let totalResult = [];
    cards.forEach(element => {
        let result = createCard(element);
        if(createCard(element) == 'Error'){
            throw new Error(`Invalid card: ${element}`)
        }
        totalResult.push(result);
    });

    console.log(totalResult.join(' '))
    
}

console.log(printDeckOfCards(['AS', '10D',  'KH', '2C']))