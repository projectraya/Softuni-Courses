function attachGradientEvents() {
    // TODO...
    const gradient = document.getElementById('gradient');

    gradient.addEventListener('mousemove', gradientMove);
    gradient.addEventListener('mouseout', gradientOut);

    function gradientMove(event){
        //offsetX = distance from start to mouse in pixels
        let power = event.offsetX / (event.target.clientWidth - 1); //radius from 0 to 1
        power = Math.trunc(power * 100); //upscaling to make it as percent, but removing decimal points with Math.trunc
        document.getElementById('result').textContent = power + "%";

    }

    function gradientOut(event){
        document.getElementById('result').textContent = "";
    }
}