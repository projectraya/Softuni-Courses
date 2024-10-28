function summerOutfits(degrees, period){
    let outfit = "";
    let shoes = "";

    if(period == "Morning")
    {
        if(degrees >= 10 && degrees <= 18){
            outfit = "Sweatshirt"
            shoes = "Sneakers"
        }
        if(degrees > 18 && degrees <= 24){
            outfit = "Shirt"
            shoes = "Moccasins"
        }
        if(degrees >= 25){
            outfit = "T-Shirt"
            shoes = "Sandals"
        }
    }
    else if(period == "Afternoon")
    {
        if(degrees >= 10 && degrees <= 18){
            outfit = "Shirt"
            shoes = "Moccasins"
        }
        if(degrees > 18 && degrees <= 24){
            
            outfit = "T-Shirt"
            shoes = "Sandals"
        }
        if(degrees >= 25){
            outfit = "Swim Suit"
            shoes = "Barefoot"
        }
    }
    else if(period == "Evening")
    {
        if(degrees >= 10 && degrees <= 18){
            outfit = "Shirt"
            shoes = "Moccasins"
        }
        if(degrees > 18 && degrees <= 24){
            outfit = "Shirt"
            shoes = "Moccasins"
        }
        if(degrees >= 25){
            outfit = "Shirt"
            shoes = "Moccasins"
        }
    }
    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`)
}