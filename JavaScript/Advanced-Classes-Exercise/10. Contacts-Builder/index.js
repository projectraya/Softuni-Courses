class Contact{
    constructor(firstName, lastName, phone, email){
        this.firstName = firstName,
        this.lastName = lastName,
        this.phone = phone,
        this.email = email,
        this._online = false;
        this.divTitle = null;
    }

    set online(value){
        this._online = value;
        if(this.divTitle){
            if(value){
                this.divTitle.classList.add('online');
            }else{
                this.divTitle.classList.remove('online');
            }
        }
        
    }
    get online(){
        return this._online; 
    }

    render(id){
        const container = document.getElementById(id);
        const infoDiv = this.elementFactory('div', null, 'info');
        infoDiv.innerHTML = `
        <span>\u260E ${this.phone}</span>
        <span>\u0040 ${this.email}</span>
        `;

        infoDiv.style.display = 'none';

        const titleDiv = this.elementFactory('div', null, 'title');
        titleDiv.innerHTML = `${this.firstName} ${this.lastName}<button>\u2139</button>`;
        this.divTitle = titleDiv;

        if(this.online){
            titleDiv.classList.add('online');
        }

        const article = document.createElement('article');
        article.appendChild(titleDiv);
        article.appendChild(infoDiv);

        titleDiv.querySelector('button').addEventListener('click', () =>{
            //titleDiv.style.display = titleDiv.style.display === 'none' ? 'block' : 'none'
            if(infoDiv.style.display === 'none')
            {
                infoDiv.style.display = 'block'
            }else{
                infoDiv.style.display = 'none'
            }
            
        })

        container.appendChild(article);
    }

    elementFactory(type, content, className){
        const el = document.createElement(type);
        if(content !== null){
            el.innerHTML = content;
        }

        if(className){
            el.classList.add(className);
        }
        return el;

    }
}


let contacts = [
    new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
    new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
    new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
  ];
contacts.forEach(c => c.render('main'));
// After 1 second, change the online status to true
setTimeout(() => contacts[1].online = true, 2000);  