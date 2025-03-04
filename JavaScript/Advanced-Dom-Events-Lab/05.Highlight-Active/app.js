    function focused() {
       
        let listDiv = document.querySelectorAll('div');

        for(let element of listDiv){
            if (element.querySelector('div')) continue;

            element.addEventListener('mouseover', highlight)
            element.addEventListener('mouseout', removeHighlight)
        }
            
        function highlight(event){
            
            event.currentTarget.classList.add('focused');
        }

        function removeHighlight(event){
            
            event.currentTarget.classList.remove('focused');
        }
    }