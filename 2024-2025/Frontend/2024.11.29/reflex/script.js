

let inGame = false;
let timer = document.querySelector('#timer');
let points = document.querySelector('#points');
let arrows = document.querySelectorAll('#arrow');
let startButton = document.querySelector('button');

let currentTime;
let currentPoints;
let allClicks;
let gameInterval;


startButton.addEventListener('click', () => {

    if (inGame) {
        return;
    }

    start();

});

const refreshOutput = () => {
    timer.innerHTML = currentTime;
    points.innerHTML = currentPoints + " / " + allClicks
};

const start = () => {
    currentPoints = 0;
    currentTime = 10;
    allClicks = 0;
    inGame = true;
    startButton.disabled = true;

    refreshOutput();
    newClickableArrow();

    gameInterval = setInterval(tick, 1000);

};

const tick = () => {
    currentTime--;
    refreshOutput();

    if (currentTime === 0) {
        endGame();
    }

};

const endGame = () => {
    clearInterval(gameInterval);
    inGame = false;
    startButton.disabled = false;
    resetArrows();
};

const getRandomArrow = () => {
    return arrows[Math.floor(Math.random() * arrows.length)];
}

const clicked = (arrow) => {

    if (!inGame) {
        return;
    }

    currentPoints++;
    arrow.classList.remove('bg-red-300');
    arrow.classList.add('bg-slate-500');

    refreshOutput();
    newClickableArrow();
};

const resetArrows = () => {
    arrows.forEach(arrow => {
        arrow.classList.remove('bg-red-300');
        arrow.classList.add('bg-slate-500');
    });
};

const newClickableArrow = () => {
    let rndArrow = getRandomArrow();

    rndArrow.classList.add('bg-red-300')
    rndArrow.classList.remove('bg-slate-500');
};


document.addEventListener('keydown', (e) => {
    if (!inGame) {
        return;
    }

    let key = e.key;
    allClicks++;
    refreshOutput();
    switch (key) {
        case 'ArrowUp':
            if (arrows[0].classList.contains('bg-red-300')) {
                e.preventDefault();
                clicked(arrows[0]);
            }
            break;
        case 'ArrowRight':
            if (arrows[3].classList.contains('bg-red-300')) {
                e.preventDefault();
                clicked(arrows[3]);
            }
            break;
        case 'ArrowDown':
            if (arrows[2].classList.contains('bg-red-300')) {
                e.preventDefault();
                clicked(arrows[2]);
            }
            break;
        case 'ArrowLeft':
            if (arrows[1].classList.contains('bg-red-300')) {
                e.preventDefault();
                clicked(arrows[1]);
            }
            break;

    }

});