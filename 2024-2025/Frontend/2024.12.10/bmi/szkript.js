
const weightInput = document.querySelector('input[name="weight"]');
const heightInput = document.querySelector('input[name="height"]');
const bmiOutput = document.querySelector('input[name="output"]');
const image = document.querySelector('img');
const outputText = document.querySelector('span');

const recalc = () => {


    const weight = parseFloat(weightInput.value);
    const height = Math.pow(parseFloat(heightInput.value) / 100, 2);

    if (isNaN(weight) || isNaN(height)) {
        bmiOutput.value = "0";
        return;
    }

    const bmi = weight / height;
    bmiOutput.value = bmi.toFixed(2);

    if (bmi < 18) {
        image.src = "thin.gif";
    } else if (bmi >= 18 && bmi <= 25) {
        image.src = "normal.gif";
    } else {
        image.src = "fat.gif";
    }

    if (bmi < 16) {
        outputText.innerHTML = "Súlyos soványság";
    }
    if (bmi >= 16 && bmi <= 16.99) {
        outputText.innerHTML = "Mérsékelt soványság";
    }
    if (bmi >= 17 && bmi <= 18.49) {
        outputText.innerHTML = "Enyhe soványság";
    }
    if (bmi >= 18.5 && bmi <= 24.99) {
        outputText.innerHTML = "Normális testsúly";
    }
    if (bmi >= 25 && bmi <= 29.99) {
        outputText.innerHTML = "Túlsúly";
    }
    if (bmi >= 30 && bmi <= 34.99) {
        outputText.innerHTML = "I. fokú elhízás";
    }
    if (bmi >= 35 && bmi <= 39.99) {
        outputText.innerHTML = "II. fokú elhízás";
    }
    if (bmi >= 40) {
        outputText.innerHTML = "III. fokú elhízás";
    }

};

weightInput.addEventListener('input', recalc);
heightInput.addEventListener('input', recalc);