function school(input) {
    let teachers = [];

    for (let arg of input) {
        if (arg.endsWith(' arrives')) {
            let name = arg.replace(' arrives', '').trim();
            let Teacher = {
                name: name,
                classNames: [],
                studentsCount: 0
            };
            teachers.push(Teacher);
        } else if (arg.includes(':')) {
            let info = arg.split(':');
            let teacherName = info[0].trim();
            let [className, studentsCount] = info[1].split(', ').map(s => s.trim());

            studentsCount = Number(studentsCount);

            for (let teach of teachers) {
                if (teach.name === teacherName) {
                    teach.classNames.push({ name: className, studentsCount });
                    teach.studentsCount += studentsCount;
                }
            }
        } else if (arg.includes('+')) {
            
            let [classInQuestion, countNew] = arg.split(' + ').map(s => s.trim());
            countNew = Number(countNew);

            for (let teach of teachers) {
                for (let cl of teach.classNames) {
                    if (cl.name === classInQuestion) {
                        cl.studentsCount += countNew;
                        teach.studentsCount += countNew;
                    }
                }
            }
        } else if (arg.endsWith(' Quit')) {
            let teacherName = arg.replace(' Quit', '').trim();
            teachers = teachers.filter(teach => teach.name !== teacherName);
        }
    }


    teachers.sort((a, b) => b.studentsCount - a.studentsCount);

    for (let teach of teachers) {
        console.log(`${teach.name}: ${teach.studentsCount}`);

       
        teach.classNames.sort((a, b) => b.studentsCount - a.studentsCount);

        for (let cl of teach.classNames) {
            console.log(`>>> ${cl.name} - ${cl.studentsCount}`);
        }
    }
}


school([
    'Dan Miller arrives',
    'Janet: 12A, 30',
    'Dan Miller: 9A, 25',
    'Jorge arrives',
    'Jorge: 8B, 25',
    '12A + 2',
    '9A + 3',
    '8B + 4',
    'Liam arrives',
    'Liam: 10A, 25',
    '10A + 3',
    'Dan Miller Quit',
    'Liam: 11G, 32'
]);
