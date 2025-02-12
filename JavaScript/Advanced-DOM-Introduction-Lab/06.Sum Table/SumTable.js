function sumTable() {
    //TODO
    let table = document.getElementsByTagName('table')[0];
    let sum = 0;

    for(let r = 1; r < table.rows.length - 1; r++){

        let cost = table.rows[r].cells[1].textContent;

        if(!isNaN){
            sum += Number(cost);
        }
        
    }

    document.getElementById('sum').textContent = sum;
}