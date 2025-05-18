function attachEvents() {
//     const nameOfLocation = document.getElementById('location');
//     const btnSubmit = document.getElementById('submit');
//     const forecast = document.getElementById('forecast');


//     async function getLocation() {
//         const location = nameOfLocation.value;

//         try {
//             const response = await fetch(`http://localhost:3030/jsonstore/forecaster/locations`);
//             const data = await response.json();

//             const result = data.find(x => x.name === location);

//             if (result) {
//                 const code = result.code;
//                 return code;
//             } else {
//                 throw new Error('Location not found');
//             }
//         } catch (error) {
//             console.error('Error fetching location data:', error);
//         }
//     }
    
//     btnSubmit.addEventListener('click', async () => {
//         const code = await getLocation();
//         if (code) {
//             forecast.style.display = 'visible';
//             getTodayForecast();
//             getUpcomingForecast();
//         } else {
//             forecast.style.display = 'none';
//         }
//     });

//     async function getTodayForecast(){
//         const code = await getLocation();
//         const response = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`);
//         const data = await response.json();
//         forecast.style.display = 'visible';
//         const current = document.getElementById('current');
//         current.classList.add('forecasts');

//         const conditionSymbol = document.createElement('span');
//         conditionSymbol.classList.add('condition', 'symbol');
//         if(data.forecast.condition == 'sunny'){
//             conditionSymbol.innerHTML = '&#x2600;';

//         }else if(data.forecast.condition == 'partly sunny'){
//             conditionSymbol.innerHTML = '&#x26C5;';
//         }
//         else if(data.forecast.condition == 'overcast'){
//             conditionSymbol.innerHTML = '&#x2601;';

//         }else if(data.forecast.condition == 'rain'){
//             conditionSymbol.innerHTML = '&#x2614;';
//         }
        
        
//         current.appendChild(conditionSymbol);
//         const place = document.createElement('span');
//         const degrees = document.createElement('span');
//         const condition = document.createElement('span');

//         place.classList.add('forecast-data');
//         degrees.classList.add('forecast-data');
//         condition.classList.add('forecast-data');
//         place.textContent = data.name;
//         degrees.textContent = `${data.forecast.low}°/${data.forecast.high}°`;
//         condition.textContent = data.forecast.condition;
//         current.appendChild(place);
//         current.appendChild(degrees);
//         current.appendChild(condition);
        
//     }

//     async function getUpcomingForecast(){
//         const code = await getLocation();
//         const response = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`);
//         const data = await response.json();


//         const upcoming = document.getElementById('upcoming');
//         upcoming.classList.add('forecast-info');

//         const forecastInfo = document.createElement('span');
//         forecastInfo.classList.add('upcoming');

//         if(data.forecast.condition == 'sunny'){
//             forecastInfo.innerHTML = '&#x2600;';

//         }else if(data.forecast.condition == 'partly sunny'){
//             forecastInfo.innerHTML = '&#x26C5;';
//         }
//         else if(data.forecast.condition == 'overcast'){
//             forecastInfo.innerHTML = '&#x2601;';

//         }else if(data.forecast.condition == 'rain'){
//             forecastInfo.innerHTML = '&#x2614;';
//         }
//         const place = document.createElement('span');
//         const degrees = document.createElement('span');
//         const condition = document.createElement('span');
//         place.classList.add('forecast-data');
//         degrees.classList.add('forecast-data');
//         condition.classList.add('forecast-data');
//         place.textContent = data.name;
//         degrees.textContent = `${data.forecast.low}°/${data.forecast.high}°`;
//         condition.textContent = data.forecast.condition;
//         forecastInfo.appendChild(place);
//         forecastInfo.appendChild(degrees);
//         forecastInfo.appendChild(condition);
//         upcoming.appendChild(forecastInfo);

        
//     }

// }
const nameOfLocation = document.getElementById('location');
const btnSubmit = document.getElementById('submit');
const forecast = document.getElementById('forecast');
}
attachEvents();