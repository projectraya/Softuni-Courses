function booksForSummer(pages, pagesPerHour, days){
    let totalReadingTime = pages / pagesPerHour;
    let requiredHours = totalReadingTime / days;

    console.log(requiredHours);
}