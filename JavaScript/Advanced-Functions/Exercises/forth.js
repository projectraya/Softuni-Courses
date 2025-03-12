function solution(params){
    
    let robot = {
        ingredients: {
            protein: 0,
            carbohydrate: 0,
            fat: 0,
            flavour: 0
        },

        recipes: {
            apple: {carbohydrate: 1, flavour: 2},
            lemonade: {carbohydrate: 10, flavour: 20},
            burger: {carbohydrate: 5, fat: 7, flavour: 3},
            eggs: {protein: 5, fat: 1, flavour: 1},
            turkey: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
         },

         restock(microelement, quantity){
            this.ingredients[microelement] += Number(quantity);
            return 'Success';
         },

         prepare(recipe, quantity){
            
            for(let element in this.recipes[recipe]){ //for of won't allow us to go through the properties of recipes

                if(this.recipes[recipe][element] * quantity >= this.ingredients[element]){

                    return `Error: not enough ${element} in stock`
                }
            }
            for(const element in this.recipes[recipe]){
                this.ingredients[element] -= this.recipes[recipe][element] * quantity;
            }
            return 'Success';
         },
         report(){
            let stock = this.ingredients;
            return `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`
         }
    }
    
    return function manager(input){

        const [command, element, quantity] = input.split(' ');
        return robot[command](element, quantity);
    }
    
}

let manager = solution();
console.log(manager('restock flavour 50'))
console.log(manager('prepare lemonade 4'))
console.log(manager('restock carbohydrate 10'))
console.log(manager('restock flavour 10'))
console.log(manager('prepare apple 1'))
console.log(manager('restock fat 10'))
console.log(manager('prepare burger 1'))
console.log(manager('report'))