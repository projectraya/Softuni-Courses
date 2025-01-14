//TASK 1 - Furniture
function furniture(input){
    let regex = />>([A-Za-z]+)<<(\d+[.\d]+)!(\d{1,2})/gm

    input = input.join(" ");
    let matches;

    let furnitureNames = []
    let money = 0;

    while((matches = regex.exec(input)) !== null){
        furnitureNames.push(matches[1]); // name
        money += Number(matches[2]) * Number(matches[3]); // price * quantity

    }

    console.log(`Bought furniture:`)
    if(furnitureNames.length > 0){ //check if it was empty
        for(let name of furnitureNames){
            console.log(name)
        }
        
    }
    console.log(`Total money spend: ${money.toFixed(2)}`)

}

//furniture(['>>Sofa<<312.23!3', '>>TV<<300!5', '>Invalid<<!5', 'Purchase'])

//TASK 2 - Race
function race(input){
    //input is an array of different inputs
    let names = input[0].split(", ");
    let regexForLetters = /[a-zA-Z]/gm;
    let regexForNumbers = /\d/gm;
    
    
    let racers = []

    for(let o = 0; o < names.length; o++){

         let racer = {
            name: names[o],
            score: 0
        }
        racers.push(racer)
        
    }

    for(let i = 1; i < input.length; i++){ //for every coded string in the input

        if(input[i] !== "end of race"){ //if it isn't end
            let chars = input[i];//in an array of chars
            let nameLetters = chars.match(regexForLetters).join("");
            let numbers = chars.match(regexForNumbers);
            let sum = 0;
            for(let f = 0; f<numbers.length; f++){
                let num = Number(numbers[f]);
                sum += num;
            }
            
            for(let r of racers){
                if(nameLetters == r.name){
                    r.score += sum
                }
            }
        }
        
    }
    //print
    racers.sort((a, b) => b.score - a.score)
    for(let p = 1; p <= 3; p++){

        if(p == 1){
            console.log(`1st place: ${racers[p - 1].name}`)
        }else if(p == 2){
            console.log(`2nd place: ${racers[p - 1].name}`)
        }else if(p == 3){
            console.log(`3rd place: ${racers[p - 1].name}`)
        }
        
    }

}

// race(["George, Peter, Bill, Tom",
//     "G4e@55or%6g6!68e!!@",
//     "R1@!3a$y4456@",
//     "B5@i@#123ll",
//     "G@e54o$r6ge#",
//     "7P%et^#e5346r",
//     "T$o553m&6",
//     "end of race"])
    

//TASK 3 - softUni bar income 

function softUniBarIncome(input){
//input is an array
let regex = /%(?<a>[A-Z][a-z]+)%<(?<b>[A-Z][a-z]+)>\|(?<c>\d+)\|(?<d>[\d.]+)\$/gm
 //this regex will have 4 groups - customer, product, quantity, price
let totalIncome = 0

for(let i = 0; i < input.length; i++){
    let subinput = input[i];
    if(subinput == "end of shift"){
        console.log(`Total income: ${totalIncome}`)
        break;
    }
    
    let match = regex.exec(subinput);
    let totalPrice = 0;
    let customer;
    let product;
    let quantity;
    let price;

    if(match != null){
        customer = match.groups['a']
        product = match.groups['b']
        quantity = Number(match.groups['c'])
        price = Number(match.groups['d'])
        totalPrice = quantity * price;
    }

    totalIncome += totalPrice
    console.log(`${customer}: ${product} - ${totalPrice}`)

    customer = ''
    product = ''
    quantity = ''
    price = ''
}
}

softUniBarIncome(['%George%<Croissant>|2|10.3$', '%Peter%<Gum>|1|1.3$', '%Peter%<Gum>|1|1.3$', '%Maria%<Cola>|1|2.4$', 'end of shift'])