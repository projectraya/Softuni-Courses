function attachEventsListeners() {
    
    let days = document.getElementById('days').value;
    let hours = document.getElementById('hours').value;
    let minutes = document.getElementById('minutes').value;
    let seconds = document.getElementById('seconds').value;

    days = Number(days);
    hours = Number(hours);
    minutes = Number(minutes);
    seconds = Number(seconds);


    
    document.getElementById('daysBtn').addEventListener('click', () => {

        days = document.getElementById('days').value;

        hours = days * 24;
        minutes = hours * 60;
        seconds = minutes * 60;

        document.getElementById('hours').value = hours;
        document.getElementById('minutes').value = minutes;
        document.getElementById('seconds').value = seconds;
    });

    
    document.getElementById('hoursBtn').addEventListener('click', () => {

        hours = document.getElementById('hours').value;
        days = hours / 24;
        minutes = hours * 60;
        seconds = minutes * 60;

        document.getElementById('days').value = days;
        document.getElementById('minutes').value = minutes;
        document.getElementById('seconds').value = seconds;
    });

    
    document.getElementById('minutesBtn').addEventListener('click', () => {

        minutes = document.getElementById('minutes').value;
        hours = minutes / 60;
        days = hours / 24;
        seconds = minutes * 60;

        document.getElementById('hours').value = hours;
        document.getElementById('days').value = days;
        document.getElementById('seconds').value = seconds;
    });

    
    document.getElementById('secondsBtn').addEventListener('click', () => {

        seconds = document.getElementById('seconds').value;
        minutes = seconds / 60;
        hours = minutes / 60;
        days = hours / 24;

        document.getElementById('hours').value = hours;
        document.getElementById('minutes').value = minutes;
        document.getElementById('days').value = days;
    });


}