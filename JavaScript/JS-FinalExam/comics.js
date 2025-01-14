function comic(pictures, args){

    for(let command of args){
        if(command == 'Done'){
            let lastPic = pictures.pop()
            console.log(`${lastPic} is ready for printing!`)

        }else if(command.includes('Add') && command.length == 7){

            let arr = command.split(' ')
            let picCode = arr[1]
            pictures.unshift(picCode)
        }
        else if(command.includes('Remove') && command.length == 10){

            let arr = command.split(' ')
            let startRange = arr[1]
            let endRange = arr[2]
            let removeCount = endRange - startRange
            pictures.splice(startRange, removeCount + 1)
            console.log(`Removd!`)

        }else if(command == 'End'){

            if(pictures.length < 1){
                console.log('The comic is complete')
            }else{
                console.log(`Pictures left: ${pictures.join(', ')}`)
                
            }
            return;
        }

    }
}

// comic(['R22', 'P89', 'K12'], 
//     ['Done', 'End', 'Remove 0 1'])

comic(['K12', 'P90', 'A13', 'B13', 'C34', 'D56'], 
        ['Add J98', 'Remove 1 4', 'End'])
