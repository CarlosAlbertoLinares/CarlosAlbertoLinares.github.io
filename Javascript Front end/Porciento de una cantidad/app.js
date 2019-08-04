function populate() {
    if(quiz.isEnded()) {
        showScores();
    }
    else {
        // show question
        var element = document.getElementById("question");
        element.innerHTML = quiz.getQuestionIndex().text;

        // show options
        var choices = quiz.getQuestionIndex().choices;
        for(var i = 0; i < choices.length; i++) {
            var element = document.getElementById("choice" + i);
            element.innerHTML = choices[i];
            guess("btn" + i, choices[i]);
        }

        showProgress();
    }
};

function guess(id, guess) {
    var button = document.getElementById(id);
    button.onclick = function() {
        quiz.guess(guess);
        populate();
    }
};


function showProgress() {
    var currentQuestionNumber = quiz.questionIndex + 1;
    var element = document.getElementById("progress");
    element.innerHTML = "Question " + currentQuestionNumber + " of " + quiz.questions.length;
};

function showScores() {
    var gameOverHTML = "<h1>Result</h1>";
    gameOverHTML += "<h2 id='score'> Your scores: " + quiz.score + "</h2>";
    var element = document.getElementById("quiz");
    element.innerHTML = gameOverHTML;
};

// create questions

  var questions = [
    new Question("Aumentar en un 35% la cantidad de 4,720, resulta en", ["6,372", "6,370","130", "135"], "6,372"),
    new Question("Aumentar en un 20% la cantidad 2,100,resulta en", ["2500", "2408", "2520", "2300"], "2520"),
    new Question("Aumentar en un 53% la cantidad 5000, resulta en", ["7200", "5900","7850", "7650"], "7650"),
    new Question("Aumentar en un 42% la cantidad 15, resulta en", ["21.3", "25.7", "18.5", "23"], "21.3"),
    new Question("Aumentar en un 50% la cantidad 50, resulta en", ["103", "8", "100", "84"], "100")

];

// create quiz
var quiz = new Quiz(questions);

// display quiz
populate();





