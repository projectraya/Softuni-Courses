const symbols = {
    "Sunny": '\u2600',
    "Partly sunny": '\u26C5',
    "Overcast": '\u2601',
    "Rain": '\u2614'
}

function attachEvents() {
    const locationInput = document.getElementById('location');
    const btnSubmit = document.getElementById('submit');
    const forecast = document.getElementById('forecast');
    const current = document.getElementById('current');
    const upcoming = document.getElementById('upcoming');

    btnSubmit.addEventListener('click', async () => {
        const city = locationInput.value; // locations
        forecast.style.display = 'none';
        current.querySelectorAll('.forecasts').forEach(x => x.remove());
        upcoming.querySelectorAll('.forecast-info').forEach(x => x.remove());
        try {
            const res = await fetch('http://localhost:3030/jsonstore/forecaster/locations');
            if (!res.ok) {
                throw new Error();
            }
            const data = await res.json();
            const location = data.find(x => x.name.toLowerCase() === city.toLowerCase()); // city
            const [today, up] = await Promise.all([
                fetch(`http://localhost:3030/jsonstore/forecaster/today/${location.code}`),
                fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${location.code}`)
            ]);
            if (!today.ok || !up.ok) { throw new Error(); }
            const todayData = await today.json();
            const upData = await up.json();
            renderCurrent(todayData);
            renderUpcoming(upData);
            forecast.style.display = 'block';
        } catch (error) {
            forecast.style.display = 'block';
            forecast.firstElementChild.textContent = 'Error';
            console.error(error, 'Error msg');
        }
    })

    function renderCurrent({ name, forecast: { low, high, condition } }) {
        const div = document.createElement('div');
        div.className = 'forecasts';
        div.innerHTML = `
        <span class="condition symbol">${symbols[condition]}</span>
        <span class="condition">
            <span class="forecasts-data">${name}</span>
            <span class="forecasts-data">${low}*/${high}*</span>
            <span class="forecasts-data">${condition}</span>
        </span>
        `;
        current.appendChild(div);
    }

    function renderUpcoming({ forecast }) { // {}
        const info = document.createElement('div');
        info.className = 'forecast-info';

        forecast.forEach(day => {
            const span = document.createElement('span');
            span.className = 'upcoming';
            span.innerHTML = `
            <span class="symbol">${symbols[day.condition]}</span>
            <span class="forecast-data">${day.low}*/${day.high}*</span>
            <span class="forecast-data">${day.condition}</span>
            `;
            info.appendChild(span);
        });
        upcoming.appendChild(info);
    }
}

attachEvents();

// function attachBefore(){
//     //     const nameOfLocation = document.getElementById('location');
// //     const btnSubmit = document.getElementById('submit');
// //     const forecast = document.getElementById('forecast');


// //     async function getLocation() {
// //         const location = nameOfLocation.value;

// //         try {
// //             const response = await fetch(`http://localhost:3030/jsonstore/forecaster/locations`);
// //             const data = await response.json();

// //             const result = data.find(x => x.name === location);

// //             if (result) {
// //                 const code = result.code;
// //                 return code;
// //             } else {
// //                 throw new Error('Location not found');
// //             }
// //         } catch (error) {
// //             console.error('Error fetching location data:', error);
// //         }
// //     }
    
// //     btnSubmit.addEventListener('click', async () => {
// //         const code = await getLocation();
// //         if (code) {
// //             forecast.style.display = 'visible';
// //             getTodayForecast();
// //             getUpcomingForecast();
// //         } else {
// //             forecast.style.display = 'none';
// //         }
// //     });

// //     async function getTodayForecast(){
// //         const code = await getLocation();
// //         const response = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`);
// //         const data = await response.json();
// //         forecast.style.display = 'visible';
// //         const current = document.getElementById('current');
// //         current.classList.add('forecasts');

// //         const conditionSymbol = document.createElement('span');
// //         conditionSymbol.classList.add('condition', 'symbol');
// //         if(data.forecast.condition == 'sunny'){
// //             conditionSymbol.innerHTML = '&#x2600;';

// //         }else if(data.forecast.condition == 'partly sunny'){
// //             conditionSymbol.innerHTML = '&#x26C5;';
// //         }
// //         else if(data.forecast.condition == 'overcast'){
// //             conditionSymbol.innerHTML = '&#x2601;';

// //         }else if(data.forecast.condition == 'rain'){
// //             conditionSymbol.innerHTML = '&#x2614;';
// //         }
        
        
// //         current.appendChild(conditionSymbol);
// //         const place = document.createElement('span');
// //         const degrees = document.createElement('span');
// //         const condition = document.createElement('span');

// //         place.classList.add('forecast-data');
// //         degrees.classList.add('forecast-data');
// //         condition.classList.add('forecast-data');
// //         place.textContent = data.name;
// //         degrees.textContent = `${data.forecast.low}°/${data.forecast.high}°`;
// //         condition.textContent = data.forecast.condition;
// //         current.appendChild(place);
// //         current.appendChild(degrees);
// //         current.appendChild(condition);
        
// //     }

// //     async function getUpcomingForecast(){
// //         const code = await getLocation();
// //         const response = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`);
// //         const data = await response.json();


// //         const upcoming = document.getElementById('upcoming');
// //         upcoming.classList.add('forecast-info');

// //         const forecastInfo = document.createElement('span');
// //         forecastInfo.classList.add('upcoming');

// //         if(data.forecast.condition == 'sunny'){
// //             forecastInfo.innerHTML = '&#x2600;';

// //         }else if(data.forecast.condition == 'partly sunny'){
// //             forecastInfo.innerHTML = '&#x26C5;';
// //         }
// //         else if(data.forecast.condition == 'overcast'){
// //             forecastInfo.innerHTML = '&#x2601;';

// //         }else if(data.forecast.condition == 'rain'){
// //             forecastInfo.innerHTML = '&#x2614;';
// //         }
// //         const place = document.createElement('span');
// //         const degrees = document.createElement('span');
// //         const condition = document.createElement('span');
// //         place.classList.add('forecast-data');
// //         degrees.classList.add('forecast-data');
// //         condition.classList.add('forecast-data');
// //         place.textContent = data.name;
// //         degrees.textContent = `${data.forecast.low}°/${data.forecast.high}°`;
// //         condition.textContent = data.forecast.condition;
// //         forecastInfo.appendChild(place);
// //         forecastInfo.appendChild(degrees);
// //         forecastInfo.appendChild(condition);
// //         upcoming.appendChild(forecastInfo);

        
// //     }

// // }
// }