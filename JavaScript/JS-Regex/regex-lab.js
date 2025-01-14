function matchDates(dates){
    dates = dates.split(', ')
    let regex = /(?<day>\d{2})(?<separator>[.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})/g
    
    while((validDate = regex.exec(dates)) != null){
        let day = validDate.groups['day']
        let month = validDate.groups['month']
        let year = validDate.groups['year']
        console.log(`Day: ${day}, Month: ${month}, Year: ${year}`)
    }


}

//matchDates('13/Jul/1928, 10-Nov-1934, 01/Jan-1951, 25.Dec.1937, 23/09/1973, 1/Feb/2016')

function matchFullName(names){
    const regexp = /\b[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\b/g
    let nameList = []
    let matches = regexp.exec(names)

    while(matches != null){
        nameList.push(matches[0]);
        matches = regexp.exec(names);
    }
    console.log(nameList.join(" "));
}

//matchFullName('Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan Ivanov')

function matchPhoneNumber(numbers){
    let pattern = /(\+359)([-| ])2(\2)(\d{3})(\2)(\d{4})\b/g
    let validPhones = [];
    while((validPhone = pattern.exec(numbers)) !== null){
        validPhones.push(validPhone[0])
    }

    console.log(validPhones.join(', '))
}
matchPhoneNumber('+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222')