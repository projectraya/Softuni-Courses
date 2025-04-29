
class Person{

    toString() {
       return `${this.constructor.name} name: ${this.name}, email: ${this.email}`
    }
    constructor(name, email){
        this.name= name,
        this.email = email
        

        // Object.defineProperty(this, "toString",{
            
        //     get: function(){
    
        //          return `${this.constructor.name} name: ${this.name}, email: ${this.email}`
        //     }
        // })
    }
    
    
}


class Teacher extends Person{

    constructor(name, email, subject){
        super(name, email),
        this.subject = subject
       
    }

    toString (){
        return super.toString() + `, subject: ${this.subject}`;
    }

}

class Student extends Person{

    constructor(name, email, course){
        super(name, email),
        this.course = course
        
    }
    toString (){
        return super.toString() + `, course: ${this.course}`;
    }
    
}

let person = new Person("raya", "raya@bg");
console.log(person.toString());

let teacher = new Teacher("ivanzhela", "ivanzhel@bg", "javaScript")
console.log(teacher.toString());

function toStringExtension(){

    return{
        Person,
        Teacher,
        Student
    }
    
}


console.log(toStringExtension());


