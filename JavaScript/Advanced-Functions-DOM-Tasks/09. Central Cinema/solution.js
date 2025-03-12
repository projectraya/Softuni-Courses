function solve() {
    const inputs = document.querySelector("#container button");
    inputs.addEventListener("click", addMovie);

    function addMovie(e){
        e.preventDefault();
        const [name, hall, ticketPrice] = Array.from(document.querySelectorAll('#container input'));

        let nameInput = name.value.toString().length > 0 ? name.value : undefined;
        let hallInput = hall.value.toString().length > 0 ? hall.value : undefined;

        let ticketInput = typeof Number(ticketPrice.value) === 'number' ? ticketPrice.value : undefined;

        if(nameInput && hallInput && ticketInput){

            const ul = document.getElementById('movies');
            let li = document.createElement('li');
            let spanElement = document.createElement('span');
            spanElement.textContent = nameInput;
            let div = document.createElement('div');
            let strong = document.createElement('strong');
            strong.textContent = ticketInput;
            let input = document.createElement('input');
            input.placeholder = 'Tickets Sold';
            let btn = document.createElement('button');
            btn.textContent = 'Archive';


            div.appendChild(strong);
            div.appendChild(input);
            div.appendChild(btn);
            div.appendChild(spanElement);
            li.appendChild(div);
            

            ul.appendChild(li);

        }
    }
}