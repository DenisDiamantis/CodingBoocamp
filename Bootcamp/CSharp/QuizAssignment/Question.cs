﻿
namespace Assignment
{
    class Question
    {
        public string questionText;
        public string optionA;
        public string optionB;
        public string optionC;
        public string optionD;
        public char correctAnswerLetter;
        private static char defaultCorrectAnswerLetter = 'X';
        public int tries = 2;

        //A constructor that initializes questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        public Question()
        {
            questionText = null;
            optionA = null;
            optionB = null;
            optionC = null;
            optionD = null;
            correctAnswerLetter = Question.defaultCorrectAnswerLetter; //defaultCorrectAnswerLetter is a static field
        }

        //A constructor that receives questionText as parameter and initializes questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        public Question(string questionText)
        {
            this.questionText = questionText;
            optionA = null;
            optionB = null;
            optionC = null;
            optionD = null;
            correctAnswerLetter = Question.defaultCorrectAnswerLetter; //defaultCorrectAnswerLetter is a static field
        }

        //A constructor that initializes questionText, optionA, optionB, optionC, optionD and correctAnswerText
        public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D') //validating correctAnswerLetter parameter
                this.correctAnswerLetter = correctAnswerLetter;
            else
                this.correctAnswerLetter = Question.defaultCorrectAnswerLetter; //defaultCorrectAnswerLetter is a static field
        }

        //A method that returns true, if at least two options are not null
        public bool AreOptionsValid()
        {
            return (optionA != null || optionB != null) && (optionC != null || optionD != null);
        }
    }
}
