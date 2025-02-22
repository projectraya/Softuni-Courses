    function focused() {
        //TODO...
        let listDiv = document.querySelectorAll('div');

        for(let element of listDiv){
            if (element.querySelector('div')) continue;

            element.addEventListener('mouseover', highlight)
            element.addEventListener('mouseout', removeHighlight)
        }
            
        function highlight(event){
            
            event.currentTarget.style.backgroundColor = '#999999';
        }

        function removeHighlight(event){
            
            event.currentTarget.style.backgroundColor = '';
        }
    }