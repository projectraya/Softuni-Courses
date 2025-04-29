function printPersons(){

    class person{
        
        constructor(fName, lName, age, email){
    
            this.fName = fName,
            this.lName = lName,
            this.age = age,
            this.email = email
        }
        toString(){
            return `${this.fName} ${this.lName}(age: ${this.age}, email: ${this.email})`;
        }
    }
    let personAnna = new person('Anna', 'Gae', 12, 'anna.fag@mail')
    let personStef = new person('John', 'Walk', 3, 'ivan@mail')
    let personMe = new person('Raya', 'Minkova', 17, 'raya@mail')

    let arr = [personAnna.toString(), personStef.toString(), personMe.toString()];
    
    return arr;
}

console.log(printPersons())
