function shopCalculator(name, city, quantity){
    let result = "";
    switch (city){
         case "Sofia": 
         if(name == "coffee"){
            result = 0.5 * quantity;
         }else if(name == "water"){
            result = 0.8 * quantity;
         }
         break;
         case "Plovdiv":
            if(name == "coffee"){
                result = 0.4 * quantity;
             }else if(name == "water"){
                result = 0.7 * quantity;
             } break;
         case "Varna":
            if(name == "coffee"){
                result = 0.45 * quantity;
             }else if(name == "water"){
                result = 0.7 * quantity;
             } break;
    
    }
    return result;
}

console.log(shopCalculator("water", "Sofia", 5));