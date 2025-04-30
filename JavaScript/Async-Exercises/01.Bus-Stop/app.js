async function getInfo() {
    const stopId = document.getElementById("stopId").value;
    const buses = document.getElementById("buses");
    const stopName = document.getElementById("stopName");
    const BASE_URL = "http://localhost:3030/jsonstore/bus/businfo/"
    
    buses.innerHTML = "";

    try{
        const res = await fetch(`${BASE_URL}${stopId}`);
        const data = await res.json();
        for (const [key, value] of Object.entries(data.buses)) {
            const li = document.createElement("li");
            li.textContent = `Bus ${key} arrives in ${value} minutes`;
            buses.appendChild(li);
        }
        stopName.textContent = data.name;
    }
    catch(err) {
        stopName.textContent = "Error";
    }

    // fetch(`${BASE_URL}${stopId}`)
    //     .then(res => {
    //         if (res.status !== 200) {
    //             throw new Error("Error: " + res.status);
    //         }
    //         return res.json();

    //     }).then(data => {

    //         for (const [key, value] of Object.entries(data.buses)) {
    //             const li = document.createElement("li");
    //             li.textContent = `Bus ${key} arrives in ${value} minutes`;
    //             buses.appendChild(li);
    //         }
    //         document.getElementById("stopName").textContent = data.name;
            

    //     }).catch(err => {
    //         console.error(err);
    //         document.getElementById("stopName").textContent = "Error";
    //     });

}