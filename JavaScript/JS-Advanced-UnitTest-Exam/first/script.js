function solve(array, command){

    if(command === 'asc')
    {
        array = array.sort((a, b) => a.localeCompare(b))
    }
    else if(command === 'desc')
    {
        array = array.sort((a, b) => b.localeCompare(a));
    }

    console.log(array);
}

solve(['a', 'n', 'k', 'b', 'c'], 'asc');