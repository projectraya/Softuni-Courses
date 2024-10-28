function rightPlace(firstString, symbol, secondString){
    let res = firstString.replace("_", symbol);
    let output = res === secondString ? "Matched" : "NotMatched";

    console.log(output);
}