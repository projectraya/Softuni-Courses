function winningCard(inputCard){

    let regex = /[&*%#]+/gm

    if(inputCard.length <= 5){
        console.log('Invalid Bingo Card')
        return;
    }

    if(inputCard.length >= 6 && inputCard.length < 20){

    }else if(inputCard.length == 20){ //for winning bingo

        let leftHalf = inputCard.substring(0, 10) // first 10
        console.log(leftHalf)
        let rightHalf = inputCard.substring(10, 20) //second 10
        console.log(rightHalf)



        if(matchLeft[0] == matchRight[0]){
            console.log(`Bingo!     ${inputCard}    -   10 simbols: ${leftHalf.substring(0, 1)}`)
        }

    }
}

winningCard('Bing&&&&&&Oo&&&&&&ye')
winningCard('&&&&&&&&&&&&&&&&&&&&')
winningCard('sdfndjfvbvbdhvfhvbhf')
