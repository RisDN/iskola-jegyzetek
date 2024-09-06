const url = 'https://api.github.com/repos/javascript-tutorial/en.javascript.info/commits';
const kijelzo = document.querySelector('h1')
async function vanENet() {
    try {
        let res = await fetch(url);
        if(res.ok) {kijelzo.innerHTML = "Van!"} 
    } catch (error) {
        kijelzo.innerHTML = "Nincs!"
    }

}

vanENet()
setInterval(function() {
    vanENet()
}, 1000)