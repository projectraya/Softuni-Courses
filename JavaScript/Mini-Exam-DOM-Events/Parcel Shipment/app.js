function solution() {
    
    let trackingNumInput = document.getElementsByTagName('input')[0];
    let registerBtn = document.getElementById('registerButton');

    registerBtn.addEventListener('click', () => {

        let createElement = document.createElement('li');
        
        let listOfParcels = document.getElementsByTagName('ul')[0];

        createElement.textContent = trackingNumInput.value;
        let createBtn = document.createElement('button');
        
        
        createBtn.textContent = 'Send';
        createElement.appendChild(createBtn);
        listOfParcels.append(createElement);

        trackingNumInput.value = '';
        
        createBtn.addEventListener('click', () => {

            
            let listOfSent = document.getElementsByTagName('ul')[1];
            listOfSent.appendChild(createElement)
            createElement.removeChild(createBtn);

        })

        let sorted = Array.from(listOfParcels.children);
        sorted.sort((one, two) => one.textContent.localeCompare(two.textContent))

        for(let element of sorted){
            listOfParcels.appendChild(element);
        }
    })


}