function solve() {
    let btn = document.querySelector('body > div > div > aside > section > form > button');

    btn.addEventListener('click', (event) => {
        event.preventDefault(); // Prevent form submission

        let authorValue = document.getElementById('creator').value;
        let titleValue = document.getElementById('title').value;
        let contentValue = document.getElementById('content').value;

        if (!authorValue || !titleValue || !contentValue) {
            return; // Do nothing if any field is empty
        }

        let article = document.createElement('article');

        let title = document.createElement('h1');
        title.textContent = titleValue;

        let author = document.createElement('p');
        author.textContent = `Author: ${authorValue}`;

        let content = document.createElement('p');
        content.textContent = contentValue;

        let divButtons = document.createElement('div');
        divButtons.className = 'buttons';
        let deleteBtn = document.createElement('button');
        deleteBtn.textContent = 'Delete';
        deleteBtn.className = 'btn delete'; 
        deleteBtn.addEventListener('click', () => {
            article.remove(); // Remove the article when the button is clicked
        });

        divButtons.appendChild(deleteBtn);
        article.appendChild(title);
        article.appendChild(author);
        article.appendChild(content);
        article.appendChild(divButtons); // Append the divButtons to the article
        

        let location = document.querySelector('body > div > div > main > section');
        location.appendChild(article);

        // Clear input fields after submission
        document.getElementById('creator').value = '';
        document.getElementById('title').value = '';
        document.getElementById('content').value = '';
    });
}

