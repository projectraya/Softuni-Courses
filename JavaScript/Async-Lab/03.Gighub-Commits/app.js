function loadCommits() {
    
    let username = document.getElementById("username").value;
    let repo = document.getElementById("repo").value;
    const url = `https://api.github.com/repos/${username}/${repo}/commits`;


    fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error('Error:' + response.status + ' ' + response.statusText);
            }
            return response.json();
        })  
        .then(data => {
            const commitList = document.getElementById("commits");
            commitList.innerHTML = ""; // Clear previous results

            data.forEach(commit => {
                const li = document.createElement("li");
                li.textContent = `${commit.commit.author.name}: ${commit.commit.message}`;
                commitList.appendChild(li);
            });
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}