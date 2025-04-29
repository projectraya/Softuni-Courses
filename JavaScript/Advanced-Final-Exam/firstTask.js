function sugarBalance(days){

    let sugarGrams = 0;
    let cookies = 0;
    let waffles = 0;
    let cupcakes = 0;

    let sugarMap = new Map();
    sugarMap.set('cookie', 1.25) //sugar content per one
    sugarMap.set('waffle', 9)
    sugarMap.set('cupcake', 5)

    for(let i = 0; i < days; i++){

        cookies = cookies + 2;
        waffles = waffles + 1;

        if(i === 5 || i === 10 || i === 15|| i === 20 || i === 25 || i === 30){
            cupcakes = cupcakes + 3;
        }
    }
    

    let totalCookieSugar = sugarMap.get('cookie') * cookies;
    let totalWaffleSugar = sugarMap.get('waffle') * waffles;
    let totalCupcakeSugar = sugarMap.get('cupcake') * cupcakes;

    sugarGrams = totalCookieSugar + totalWaffleSugar + totalCupcakeSugar;
    return `You have consumed ${sugarGrams} grams of sugar`;
}

console.log(sugarBalance(1))