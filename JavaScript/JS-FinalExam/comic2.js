function comic(pictures, args) {
    
    for (let command of args) {
        
        if (command === 'Done') {
            if (pictures.length > 0) {
                let lastPic = pictures.pop();  
                console.log(`${lastPic} is ready for printing!`);
            }

        
        } else if (command.startsWith('Add ')) {
            let arr = command.split(' ');  
            if (arr.length === 2) {
                let picCode = arr[1];  
                pictures.unshift(picCode);  
            }

        
        } else if (command.startsWith('Remove ')) {
            let arr = command.split(' ');
            if (arr.length === 3) {
                let startRange = Number(arr[1]);
                let endRange = Number(arr[2]);

                
                if (startRange >= 0 && endRange < pictures.length && startRange <= endRange) {
                    pictures.splice(startRange, endRange - startRange + 1); 
                    console.log('Removd!');
                }
            }

        
        } else if (command === 'End') {
            if (pictures.length === 0) {
                console.log('The comic is complete');
            } else {
                console.log(`Pictures left: ${pictures.join(', ')}`);
            }
            return;  
        }
    }
}


comic(['R22', 'P89', 'K12'], ['Done', 'End', 'Remove 0 1']);
