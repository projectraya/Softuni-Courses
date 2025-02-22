document.addEventListener('DOMContentLoaded', function(){

    let button = document.getElementById('Add');  

    button.addEventListener('click', function(){
        let newElement = document.createElement('li');
        let newItem = document.getElementById('newItemText').value;
        
        let textNode = document.createTextNode(newItem);
        
        newElement.appendChild(textNode);
        document.getElementById('items').appendChild(newElement);

    })
    
})



    

  