async function lockedProfile() {
   const main = document.getElementById('main');
   main.innerHTML = '';
   try{
    const response = await fetch(`http://localhost:3030/jsonstore/advanced/profiles`);
    if(!response.ok){
        throw new Error('Error fetching data');
    }
    const data = await response.json();
    console.log(data);
    renderProfile(data);
    attachEvents();
   }catch(error){
    console.log(error);
   }

}
function renderProfile(data) {
    const profiles = Object.values(data);
    profiles.forEach(profile => {
        const profileDiv = document.createElement('div');
        profileDiv.className = 'profile';
        profileDiv.innerHTML = `
        <img src="./iconProfile2.png" class="userIcon">
        <label>Lock</label>
        <input type="radio" name="user${profile._id}Locked" value="lock" checked>
        <label>Unlock</label>
        <input type="radio" name="user${profile._id}Locked" value="unlock">
        <hr>
        <label>Username</label>
        <input type="text" name="user${profile._id}Username" value="${profile.username}" disabled readonly>
        <div id="user${profile._id}HiddenFields" class="hiddenInfo">
            <hr>
            <label>Email:</label>
            <input type="email" name="user${profile._id}Email" value="${profile.email}" disabled readonly>
            <label>Age:</label>
            <input type="text" name="user${profile._id}Age" value="${profile.age}" disabled readonly>
        </div>
        <button>Show more</button>
        `;
        main.appendChild(profileDiv);
    })
}
function attachEvents() {
    document.querySelectorAll('.profile').forEach( profile => {
        const button = profile.querySelector('button');
        button.addEventListener('click', () => {
            const lockRadio = profile.querySelector('input[type="radio"][value="lock"]');
            const hiddenFields = profile.querySelector('.hiddenInfo');
            if (lockRadio.checked) {
                return;
            }
            if (button.textContent === 'Show more') {
                hiddenFields.style.display = 'block';
                button.textContent = 'Hide it';
            } else {
                hiddenFields.style.display = 'none';
                button.textContent = 'Show more';
            }
        })
    })
}
document.addEventListener('DOMContentLoaded', lockedProfile);