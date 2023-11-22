using Assignment;

public class Questionnaire
{
    static void Main()
    {
        Question question1 = new Question(); //Create an object of Question class and pass no arguments to the constructor
        Question question2 = new Question("In which continent is costa rica situated?"); //Create an object of Question class and pass value for questionText only to the constructor.
        Question question3 = new Question("In which continent is costa rica situated?", "Asia", "North America", "South America", "Africa", 'B'); //Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        Question question4 = new Question() { questionText = "In which continent is costa rica situated?", optionA = "Asia", optionB = "North America", optionC = "South America", optionD = "Africa" }; //Create an object for Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.



        System.Console.WriteLine(question3.questionText);
        System.Console.WriteLine("A: " + question3.optionA);
        System.Console.WriteLine("B: " + question3.optionB);
        System.Console.WriteLine("C: " + question3.optionC);
        System.Console.WriteLine("D: " + question3.optionD);

        do
        {
            System.Console.WriteLine("You have " + question3.tries + " tries left.");
            System.Console.Write("Select your answer A,B,C or D then press ENTER: ");

            char answer = char.Parse(System.Console.ReadLine());
            if (answer.ToString().ToUpper() == "A" || answer.ToString().ToUpper() == "B" || answer.ToString().ToUpper() == "C" || answer.ToString().ToUpper() == "D")
            {
                question3.tries--;
                if (answer.ToString().ToUpper() == question3.correctAnswerLetter.ToString())
                {
                    System.Console.WriteLine("You are correct!");
                    break;
                }
                else
                {
                    System.Console.WriteLine("You are wrong!");
                    if (question3.tries > 0)
                    {
                        System.Console.Write("Try again...\n");
                    }
                    else { System.Console.WriteLine("You used up your tries! Goodbye!"); }

                }
            }
            else { System.Console.Write("Invalid input try again...\n"); }
        } while (question3.tries > 0);

        System.Console.ReadKey();
    }
}