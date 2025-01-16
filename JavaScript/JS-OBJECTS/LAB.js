//one

function personInfo(firstName, lastName, age){
    let person = {}
    person.firstName = firstName
    person.lastName = lastName
    person.age = age
    return person;
}

//console.log(personInfo('Peter', 'Pan', 10));


//two
function cityInfo(city){

    for(const key of Object.keys(city)){
        console.log(`${key} -> ${city[key]}`)
    }
    
   
}


//cityInfo({name: "Sofia", area: 492, population: 12345678, country: "Bulgaria", postcode: "1000"})

//three
function convertToObject(json){
    let obj = JSON.parse(json)
    for(const key in obj){
        console.log(`${key}: ${obj[key]}`)
    }

}
//convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');

//four
function convertToJSON(name, lastName, hairColor){
    let person = {
        name,
        lastName,
        hairColor
    }
    let personAsJsn = JSON.stringify(person)
    console.log(personAsJsn);
}

//convertToJSON('George', 'Jones', 'Brown')

//five
function catsInfo(catArray){

    let cats = [];
    class Cat{
        constructor(name, age){
            this.name = name;
            this.age = age;
            this.meow = 'Meow'
        }
        
    }

    for(let i = 0; i < catArray.length; i++){
        let catData = catArray[i].split(' ');
        let [name, age] = catData;
        let cat = new Cat(name, age);
        cats.push(cat)
    }

    for(let cat of cats){
        console.log(`${cat.name}, age ${cat.age} says ${cat.meow}`)
    }
}

catsInfo(['Mellow 2', 'Tom 5'])



//six
function songs(arr){
    let num = arr[0];
    let song = {
        typeList,
        name,
        time
    }
}

