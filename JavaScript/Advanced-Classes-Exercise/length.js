class Stringer {

    constructor(){
        this.innerString,
        this.innerLength
    }

    increaseLength(integer) {
        
        this.innerLength += integer
    }

    decreaseLength(integer){
        this.innerLength -= integer
        if(this.innerLength < 0){
            this.innerLength = 0;
        }
    }
}