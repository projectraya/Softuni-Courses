function solve() {

    const infoBox = document.getElementById('info');
    const departButton = document.getElementById('depart');
    const arriveButton = document.getElementById('arrive');

    let stop = {
        name: '',
        next: 'depot'
    }
    async function depart() {
        try{
            const response = await fetch(`http://localhost:3030/jsonstore/bus/schedule/${stop.next}`);

            if(!response.ok) {
                throw new Error('Error fetching data');
            }

            const data = await response.json();
            stop.name = data.name;
            stop.next = data.next;
            departButton.disabled = true;
            arriveButton.disabled = false;
            infoBox.textContent = `Next stop ${stop.name}`;
        }
        catch (error) {
            infoBox.textContent = 'Error';

            departButton.disabled = true;
            arriveButton.disabled = true;
            return;
        }
        infoBox.textContent = `Next stop ${stop.name}`;
    }

    function arrive() {
        infoBox.textContent = '';
        infoBox.textContent = `Arriving at ${stop.name}`;
        departButton.disabled = false;
        arriveButton.disabled = true;
        // stop.next = stop.name;
        // stop.name = '';
        // departButton.disabled = false;
        // arriveButton.disabled = true;
        // infoBox.textContent = `Next stop ${stop.name}`;

    }

    return {
        depart,
        arrive
    };
}

let result = solve();