document.addEventListener('DOMContentLoaded', function(){

    const btn = document.getElementById('Add');

    btn.addEventListener('click', function(){

        let input = document.getElementById('newItemText').value;
        let list = document.getElementById("items");
        if (input.length === 0) return;

        let listItem = document.createElement("li");
        listItem.textContent = input;

        let remove = document.createElement("a");
        let linkText = document.createTextNode("[Delete]");


        remove.appendChild(linkText);

        remove.href = "#";
        remove.addEventListener("click", deleteItem);
        listItem.appendChild(remove);
        list.appendChild(listItem);

        function deleteItem() {

            listItem.remove();

        }
    })})
