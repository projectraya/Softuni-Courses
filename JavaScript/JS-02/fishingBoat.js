function fishingBoat(budget, season, fishermen){

    let rent = 0;
    let discount = 0;
    let extra = 0;

    if(fishermen <= 6){
        discount = 0.10;
    }else if(fishermen >= 7 && fishermen <= 11){
        discount = 0.15;
    }else if(fishermen >= 12){
        discount = 0.25;
    }


    if(season == "Spring")
    {
         rent = 3000; 
    }
    else if(season == "Summer")
    {
        rent = 4200;
    }
    else if(season == "Autumn")
    {
        rent = 4200;
    }
    else if(season == "Winter")
    {
        rent = 2600;
    }

    let calculation = rent  - rent * discount;
    if(fishermen % 2 == 0 && season != "Autumn"){
        extra = 0.05;
        calculation = calculation - calculation * extra;
    }
    if(calculation <= budget){
        console.log(`Yes! You have ${(budget - calculation).toFixed(2)} leva left.`);
    }else{
        console.log(`Not enough money! You need ${(calculation - budget).toFixed(2)} leva.`);
    }
}

fishingBoat('5000',
    'Autumn',
    '6')