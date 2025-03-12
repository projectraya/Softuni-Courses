function areaAndVolumeCalculator(area, volume, dataAsJson){

    let objects = JSON.parse(dataAsJson);
    function calc(obj){

        obj.x = Number(obj.x);
        obj.y = Number(obj.y);
        obj.z = Number(obj.z);
        let areaObj = Math.abs(area.call(obj));
        let volumeObj = Math.abs(volume.call(obj));

        return {area: areaObj, volume: volumeObj}
    }

    return objects.map(calc);
}

function area(){
    return Math.abs(this.x * this.y);
}

function volume(){
    return Math.abs(this.x * this.y * this.z);
}

let result = areaAndVolumeCalculator(area, volume, '[{"x":"1","y":"2","z":"10"},{"x":"7","y":"7","z":"10"},{"x":"5","y":"2","z":"10"}]');

console.log(result);
