function building(floors, rooms){
    floors = Number(floors);
    rooms = Number(rooms);
    let rowString = "";

    for(let f = floors; f > 0; f--){
        rowString = "";
        for(let r = 0; r < rooms; r++){
            f = Number(f)
            r = Number(r)
            if(f == floors){
                rowString += `L${f}${r} `;
                
                continue;
            }
           

            if(f % 2 == 0){
                rowString += `O${f}${r} `;
                
                
            } 
           

            if(f % 2 == 1){
                rowString += `A${f}${r} `;
                
            }
            
            
        }
        console.log(rowString)
       
    }
}

building(6, 4);