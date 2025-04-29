class Hex{

    
    constructor(value){
        this.value = value
        
    }

    valueOf(){
        return this.value;
    }

    toString(){
        return '0x' + this.value.toString(16).toUpperCase();
    }

    plus(hex){
        return new Hex(this.value + hex.valueOf());
    }

    minus(hex){
        return new Hex(this.value - hex.valueOf());
    }

    static parse(string){
        return string.toString(16, 10);
    }
}

let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');
console.log(Hex.parse('AAA'));