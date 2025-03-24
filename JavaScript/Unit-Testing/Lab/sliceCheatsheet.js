// THE JAVASCRIPT SLICING CHEAT SHEET
let index = ["zero", "one", "two", "three", "four", "five", "six"]
let ithElement = ["first", "second", "third", "fourth", "fifth", "sixth", "seventh"]
let nElements = ["one", "two", "three", "four", "five", "six", "seven"]

// For any array, where `i` and/or `j` is an index, and `n` is a number of elements, 
// you can remember a few common operations as follows:

// #1: From i to the end
function fromIthElementToEnd(i) {
    console.log("You'll need: ", `arr.slice(${i})`)
    return index.slice(i) 
}
// #2: From the beginning to i
function fromBeginningToIthElement(i) {
    console.log("You'll need: ", `arr.slice(0, ${i + 1})`) 
    return ithElement.slice(0, i + 1)
}
// #3: From i to j
function fromIthElementToJthElement(i, j) {
    console.log("You'll need: ", `arr.slice(${i}, ${j + 1})`) 
    return ithElement.slice(i, j+1)
}
// #4: The first n items
function firstN(n) {
    console.log("You'll need: ", `arr.slice(${n})`)
    return nElements.slice(0, n)
}
// #5: The last n items
function lastN(n) {
    console.log("You'll need: ", `arr.slice(-${n})`)
    return nElements.slice(-n)
}

// #6: These n elements starting with the ith element:
function nElementsStartingWithIth(n, i) {
    console.log("You'll need: ", `arr.slice(${i}, ${i + n})`)
    return nElements.slice(i, i + n)
}