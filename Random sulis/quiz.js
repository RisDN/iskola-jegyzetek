const ingameQuestions = []
const inGameAnswers = []

const randomQuestion = () => {
    return questions[Math.floor(Math.random() * questions.length)];
}

const shuffle = (array) => {
    let currentIndex = array.length,
        randomIndex;
    while (currentIndex != 0) {
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex--;
        [array[currentIndex], array[randomIndex]] = [
            array[randomIndex], array[currentIndex]
        ];
    }
    return array;
}

const randomAnswer = (answer) => {
    let possibs = []
    while (possibs.length < 3) {
        let random = randomQuestion()
        if (random.answer != answer && !possibs.includes(random.answer)) {
            possibs.push(random.answer)
        }
    }
    return possibs
}

const newQuestion = () => {
    let question = randomQuestion()
    if (!ingameQuestions.includes(question)) {
        let possibAnswers = randomAnswer(question.answer)
        possibAnswers.push(question.answer)
        shuffle(possibAnswers)
        ingameQuestions.push(question)
        let answerElements = document.querySelectorAll('#answer')
        for (let i = 0; i < answerElements.length; i++) {
            answerElements[i].innerHTML = possibAnswers[i]
        }
        document.querySelector('#question').innerHTML = question.question
    } else {
        if (questions.length != inGameAnswers.length) {
            newQuestion()
        } else {
            console.log('Vége')
            resultScreen()
        }

    }
    document.querySelector('#points').innerHTML = `Quiz!<br>${inGameAnswers.length+1}/${questions.length}`
}

document.querySelectorAll('#answer').forEach((elem) => {
    elem.addEventListener('click', () => {
        inGameAnswers.push(elem.innerText)
        newQuestion()
    })
})

const checkAnswer = (question, answergave) => {
    return question.answer == answergave ? 'correct' : 'incorrect'
}

const resultScreen = () => {
    let goodAnswers = 0
    document.querySelector('#quiz').style.display = 'none'
    document.querySelector('#results').style.display = 'block'
    for (let i = 0; i < inGameAnswers.length; i++) {
        let answerCheck = checkAnswer(ingameQuestions[i], inGameAnswers[i])
        console.log(answerCheck)
        if (answerCheck == 'correct') {
            goodAnswers++
            console.log('Helyes')
        }
        document.querySelector('table').innerHTML +=
            `
        <tr class="${answerCheck}">
            <td>${ingameQuestions[i].question}</td>
            <td>${ingameQuestions[i].answer}</td>
            <td>${inGameAnswers[i]}</td>
        </tr>
        `


    }
    updatePoints(goodAnswers)
}

const updatePoints = (endPoints) => {
    setTimeout(() => {
        document.querySelector('#points').innerHTML = `Quiz vége!<br>Helyes válaszok: ${endPoints}/${questions.length}`
    }, 25)
}

document.querySelector('#points').innerHTML = `Quiz!<br>0/${questions.length}`
newQuestion()