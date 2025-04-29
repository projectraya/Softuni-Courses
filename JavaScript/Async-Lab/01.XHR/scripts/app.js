function loadRepos() {
   console.log("TODO...");

   let btn = document.getElementsByTagName("button")[0];
   let url = "https://api.github.com/users/testnakov/repos";
   btn.addEventListener("click", () => {
      fetch(url)
         .then((response) => {
            if (response.status === 200) {
               return response.json();
            } else {
               throw new Error("Error: " + response.status);
            }
         })
         .then((data) => {
            let div = document.getElementById("res");
            div.innerHTML = ""; // Clear previous results
            
            data.forEach((repo) => {
               let a = document.createElement("a");
               a.href = repo.html_url;
               a.textContent = repo.name;
               a.target = "_blank"; // Open in new tab
               div.appendChild(a);
               div.appendChild(document.createElement("br"));
            });
   })

}
)}