
const weightInput = document.querySelector('input[name="weight"]');
const heightInput = document.querySelector('input[name="height"]');
const bmiOutput = document.querySelector('input[name="output"]');
const image = document.querySelector('img');

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

};

weightInput.addEventListener('input', recalc);
heightInput.addEventListener('input', recalc);