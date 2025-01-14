function sortingHat1(array){
    
    let houses = [];
    let house = {
        houseNum: '',
        wizardArray: [] //will have as many  keyvaluepairs as the wizards 
    }
    let wizKeyValue = {
        key1: '', //ron weasley
        value1: '', //pure blood
        
    }

    for(let i = 0; i < array.length; i++){
        let input = array[i].split(' - ');
        let hNumber = input[0];
        let keyValueUnsplitted = input[1];

        let currentHouse = new house;
        currentHouse.houseNum = hNumber;

        let keyValueSplitted = keyValueUnsplitted.split(', ');
        for(let kvp of keyValueSplitted){
            let kvparray = kvp.split(': ');
            let key = kvparray[0];
            let value = kvparray[1];

            let wizardKeyValue = new wizKeyValue;
            wizardKeyValue.key1 = key;
            wizardKeyValue.value1 = value;

            currentHouse.wizardArray.push(wizardKeyValue);

            for(let h of houses){
                if(h.houseNum == hNumber){
                    h.wizardArray.push(wizKeyValue)
                }
            }
        }
        
        houses.push(currentHouse);
    }

    for(let h of houses){
        console.log(`House № ${h.houseNum}`)
        for(let wiz of h.wizardArray){
            console.log(`--- ${wiz.key1} - ${wiz.value1}`);
        }
    }
}

//sortingHat(['1 - Ron Weasley: Pure-blood, Type: Squib', '1 - Harry Potter: half-bloods, Wizardkind: Wizard', '2 - Hermione Granger: Muggle-born'])




function inventory(input) {
    
    let inventory = input[0].split(', ');

    for (let i = 1; i < input.length; i++) {
        if (input[i] !== 'Craft!') {
            let command = input[i].split(' - ');
            let keyCommand = command[0];
            let itemCommand = command[1];

            if (keyCommand === 'Collect') {
                
                if (!inventory.includes(itemCommand)) {
                    inventory.push(itemCommand);
                }

            } else if (keyCommand === 'Drop') {
                
                let index = inventory.indexOf(itemCommand);
                if (index !== -1) {
                    inventory.splice(index, 1);
                }

            } else if (keyCommand === 'Combine Items') {
                
                let splittedItems = itemCommand.split(':');
                let oldItem = splittedItems[0];
                let newItem = splittedItems[1];

                let oldItemIndex = inventory.indexOf(oldItem);
                if (oldItemIndex !== -1) {
                    inventory.splice(oldItemIndex + 1, 0, newItem);
                }

            } else if (keyCommand === 'Renew') {
                
                let index = inventory.indexOf(itemCommand);
                if (index !== -1) {
                    let item = inventory.splice(index, 1)[0];
                    inventory.push(item);
                }
            }
        }
    }

    
    console.log(inventory.join(', '));
}

//inventory(['Iron, Wood, Sword', 'Collect - Gold', 'Drop - Wood', 'Craft!'])





function sortingHat(array) {
    let houses = {}; 

    for (let i = 0; i < array.length; i++) {
        
        let input = array[i].split(' - ');
        let houseNumber = input[0];
        let keyValuePairs = input[1].split(', ');

        
        let wizardDetails = keyValuePairs.map(kvp => kvp.replace(':', ' -')).join(', ');

        
        if (!houses[houseNumber]) {
            houses[houseNumber] = []; 
        }
        houses[houseNumber].push(wizardDetails);
    }

    
    for (let houseNum in houses) {
        console.log(`House № ${houseNum}`);
        for (let wizard of houses[houseNum]) {
            console.log(`--- ${wizard}`);
        }
    }
}

// Test the function
sortingHat([
    '1 - Ron Weasley: Pure-blood, Type: Squib',
    '1 - Harry Potter: half-bloods, Wizardkind: Wizard',
    '2 - Hermione Granger: Muggle-born',
]);



