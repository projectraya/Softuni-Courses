function school(input){

    let teachers = []

    for(let arg of input){
        
        if(arg.endsWith(' arrives')){
           let name = arg.split(' arrives')
                let Teacher = {
                name: name,
                classNames: [],
                studentsCount: 0
            }
            teachers.push(Teacher)
        }

        else if(arg.includes(':')){
            let info = arg.split(':')
            let info2 = info[1].split(', ')

            for(let teach of teachers){
                if(teach.name == info[0]){
                    teach.classNames.push(info2[0].trim())
                    teach.studentsCount = info2[1].trim()
                }
            }
            
        }
        else if(arg.includes('+')){
            let command = arg.split(' + ')
            let classInQuestion = command[0]
            let countNew = Number(command[1])

            for(let teach of teachers){
                for(let cl of teach.classNames){
                    if(cl == classInQuestion){
                        teach.studentsCount += countNew
                    }
                }

            }
        }else if(arg.endsWith(' Quit')){
            let teacherinfo = arg.split(' Quit')
            let teacher = teacherinfo[0]

            for(let teach of teachers){
                if(teach.name == teacher){
                   teachers.remove(teach)
                }
            }
        }
    }

    for(let teach of teachers){
        console.log(`${teach.name}: ${teach.studentsCount}`)

        for(let cl of teach.classNames){
            console.log(`>>> ${cl.name}}`)
        }
    }
}

school(['Dan Miller arrives', 'Janet: 12A, 30', 'Dan Miller: 9A, 25', 'Jorge arrives', 'Jorge: 8B, 25', '12A + 2', '9A + 3', '8B + 4', 'Liam arrives', 'Liam: 10A, 25', '10A + 3', 'Dan Miller Quit', 'Liam: 11G, 32'])