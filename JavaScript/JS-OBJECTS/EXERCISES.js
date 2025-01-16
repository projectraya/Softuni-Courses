//first

function employees(namesArray){
    let employees = []
    class Employee{
        constructor(name, pn){
            this.name = name;
            this.personalNumber = pn;
        }
    }

    for(let i = 0; i < namesArray.length; i++){
        let name = namesArray[i];
        let pn = namesArray[i].length;
        let employee = new Employee(name, pn);
        employees.push(employee);
    }

    for(let emp of employees){
        console.log(`Name: ${emp.name} -- Personal Number: ${emp.personalNumber}`)
    }
}
// employees([
//     'Silas Butler',
//     'Adnaan Buckley',
//     'Juan Peterson',
//     'Brendan Villarreal'
//     ])


//second
function towns(inputArray){
    let townObject = {
        town: "",
        latitude: 0,
        longitude: 0
    }

    let towns = [];

    for(let i = 0; i < inputArray.length; i++){
        let currentTown = inputArray[i].split(' | '); //sofia, 3543543, 45353
        townObject.town = currentTown[0]; //name
        townObject.latitude = Number(currentTown[1]).toFixed(2); //latitude
        townObject.longitude = Number(currentTown[2]).toFixed(2); //longitude
        towns.push(townObject);
        townObject = {}
        
    }

    for(let t of towns){
        console.log(t);
    }
}

//towns(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625'])

//third
function storeProvision(storageArray, deliveryArray){
    let product = {}
    let products = [];
  

    for(let i = 0; i < storageArray.length; i++){
        
        if(i % 2 == 0){
            product.label = storageArray[i];
        }

        if(i % 2 != 0){
            product.quantity = Number(storageArray[i]);
            products.push(product);
            product = {}
        }

    }

    for(let i = 0; i < deliveryArray.length; i++){
        
        if(i % 2 == 0){
            product.label = deliveryArray[i];
            
        }

        if(i % 2 != 0){
            product.quantity = Number(deliveryArray[i]);
            let isProductNew = true;
            for(p of products){
                if(p.label == product.label){
                    isProductNew = false;
                    p.quantity += product.quantity;
                }
            }
            if(isProductNew){
                products.push(product);
                product = {}
            }

            
        }

    }
    for(p of products){
        console.log(`${p.label} -> ${p.quantity}`);
    }
}

// storeProvision
//     (["Chips", "5", "CocaCola", "9", "Bananas", "14", "Pasta", "4", "Juice", "2"], 
//     ["Flour", "44", "Oil", "12", "Pasta", "7", "Tomatoes", "70", "Bananas", "30"])

//forth

// function movies(array){
//     let movie = {
//         name: "",
//         director: "",
//         date: ""
//     }

//     let movies = [];
    
//     for(let i = 0; i < array.length; i++){
//         let command = array[i].split(' '); //addMovie + Fast + and + Furious
//         if(command.includes("addMovie")){ //yes
//             let regex = /(?<=addMovie\s)(.*)/;
//             movie.name = array[i].search(regex);
//             movies.push(movie)
//             movie = {};
//         }
//         if(command.includes("onDate")){ //yes
//             let dateRegex = /(?<=onDate\s)(.*)/;
//             let nameRegex = /(.*?)(?=\s+onDate)/;

//             let name = array[i].search(nameRegex);
//             if(!movies.includes(name)){
//                 movie.name = name;
//                 movie.date = array[i].search(dateRegex);
//                 movies.push(movie);
//             }
//             movie = {};
            
//         }
//         if(command.includes("directedBy")){ //yes

//             let nameRegex = /(.*?)(?=\s+directedBy)/;
//             let name = array[i].search(nameRegex);;
//             if(!movies.includes(name)){
//                 movie.name = name;
//                 let regex = /(?<=directedBy\s)(.*)/;
//                 movie.director = array[i].search(regex);
//                 movies.push(movie);
//             }
            
//             movie = {}
//         }
        

//         for(m of movies){
//             console.log(m)
//         }
//     }
// }

// movies(['addMovie Fast and Furious',
//     'addMovie Godfather',
//     'Inception directedBy Christopher Nolan',
//     'Godfather directedBy Francis Ford Coppola',
//     'Godfather onDate 29.07.2018',
//     'Fast and Furious onDate 30.07.2018',
//     'Batman onDate 01.08.2018',
//     'Fast and Furious directedBy Rob Cohen'])


    function movies(array) {
        let movies = [];
        
        for (let i = 0; i < array.length; i++) {
            let command = array[i];
            
            if (command.includes("addMovie")) {
                let name = command.match(/(?<=addMovie\s)(.*)/)[0].trim();
                movies.push({ name: name, director: "", date: "" });
            } 
            else if (command.includes("directedBy")) {
                let [name, director] = command.split(" directedBy ");
                let movie = movies.find(m => m.name === name.trim());
                if (movie) movie.director = director.trim();
            } 
            else if (command.includes("onDate")) {
                let [name, date] = command.split(" onDate ");
                let movie = movies.find(m => m.name === name.trim());
                if (movie) movie.date = date.trim();
            }
        }
    
        // Filter movies to include only those with all properties filled
        let completeMovies = movies.filter(m => m.name && m.director && m.date);
    
        for (let movie of completeMovies) {
            console.log(movie);
        }
    }
    
    // movies([
    //     'addMovie Fast and Furious',
    //     'addMovie Godfather',
    //     'Inception directedBy Christopher Nolan',
    //     'Godfather directedBy Francis Ford Coppola',
    //     'Godfather onDate 29.07.2018',
    //     'Fast and Furious onDate 30.07.2018',
    //     'Batman onDate 01.08.2018',
    //     'Fast and Furious directedBy Rob Cohen'
    // ]);


    //fifth - inventory

function inventory(input){
    
    let command = []
    let hero = {
        name: "",
        level: 0,
        items: []
    }

    let heroes = []
    for(let i = 0; i < input.length; i++){

        command = input[i].split(" / ");
        let name = command[0];
        let level = command[1];
        let items = command[2];
        
        hero.name = name;
        hero.level = level;
        hero.items = items.split(", ");
        hero.items.sort();
        hero.items = hero.items.join(", ");

        heroes.push(hero);
        hero = {}
    }
    
    heroes.sort((x, y) => x.level - y.level)
    
    
    for(let h of heroes){
        console.log(`Hero: ${h.name}\nlevel => ${h.level}\nitems => ${h.items}`)
    }
}
    
inventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'])