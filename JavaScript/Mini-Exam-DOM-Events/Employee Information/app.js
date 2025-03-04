function deleteByID() {
    
    let input = document.getElementsByTagName('input')[0].value;
    let tableIdColumn = document.querySelectorAll('#employees > tbody > tr > td:nth-child(3)');
    
    

    for(let td of tableIdColumn){

        if(td.textContent == input){
            let row = td.parentNode;
            row.parentNode.removeChild(row);
            document.getElementById('result').textContent = 'Deleted';
            
            return;
        }
    }

    document.getElementById('result').textContent = 'Not found.';
    
}