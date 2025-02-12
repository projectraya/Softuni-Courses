function colorize() {
    // TODO
    let table = document.getElementsByTagName('table')[0];

    for(let r = 1; r < table.rows.length; r++){

        if(r % 2 == 0){
            let row = table.rows[r]
            row.style.background = 'teal';
        }
    }

}