function deleteByEmail() {
    
    let email = document.getElementsByName('email')[0].value; //a collection of nodes, only 0 has value, this is how we get the email from the input
    let secondColumn = document.querySelectorAll('#customers tr td:nth-child(2)') //we get the second column from the table, the one with emails

    for(let td of secondColumn){ //we go through every table data in the email column
        if(td.textContent == email){ //if the textContent of the current row is equal to the email from the input

            let row = td.parentNode; //this gives us the row of the found element
            row.parentNode.removeChild(row); //the parent of the parent is the table, from which we remove the row.

            document.getElementById('result').textContent = "Deleted."; //deletion done
            return;
        }

    }

    document.getElementById('result').textContent = "Not found."; //no equal email found
}