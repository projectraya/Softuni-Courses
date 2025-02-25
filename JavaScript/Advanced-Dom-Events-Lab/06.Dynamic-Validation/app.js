function validate() {
    
    const email = document.getElementById('email');
    email.addEventListener('change', (e) => {

        let element = e.currentTarget;
        const pattern = /^[a-z]+@[a-z]+\.[a-z]+$/gm;

        if(!pattern.test(element.value)){
            element.classList.add('error');
            
        }else{
            element.classList.remove('error');
        }
    })
}