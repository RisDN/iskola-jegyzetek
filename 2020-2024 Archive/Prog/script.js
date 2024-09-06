document.querySelector('.button').addEventListener('click', () => {

    let values = []
    document.querySelectorAll('input').forEach((elem) => {
        values.push(elem.value)
        elem.style.border = '1.5px rgb(131, 131, 131) solid'
        let error = elem.parentElement.querySelector('.error')
        if (error) {
            elem.parentElement.querySelector('.error').style.display = 'none'
        }

    })

    let allFilled = true;
    for (let i = 0; i < values.length; i++) {
        if (values[i].length == 0) {
            allFilled = false;
            break;
        }
    }
    if (!allFilled) {
        alert('Minden mező kitöltése kötelező!')
        return;
    }

    if (!document.querySelector('#email').value.includes("@")) {
        error(document.querySelector('#email'))
        alert('Valós emailt adj meg!')
        return;
    }

    if (document.querySelector('#password').value != document.querySelector('#passwordagain').value) {
        error(document.querySelector('#passwordagain'))
        alert('A megadott jelszók nem egyeznek!')
        return;
    }

});

function error(element) {
    element.style.border = '2px red solid';
    element.parentElement.querySelector('.error').style.display = 'block'
}