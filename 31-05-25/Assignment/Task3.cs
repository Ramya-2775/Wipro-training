using System;
using System.Collections.Generic;

class Question
{
    public string Text;
    public List<string> Options;
    public int CorrectOptionIndex;

    public Question(string text, List<string> options, int correctIndex)
    {
        Text = text;
        Options = options;
        CorrectOptionIndex = correctIndex;
    }

    public void Display()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }
    }

    public bool CheckAnswer(int userChoice)
    {
        return userChoice == CorrectOptionIndex + 1; 
    }
}

/*class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>()
        {
            new Question("Which is the smallest prime number?", new List<string>{"0", "1", "2", "3"}, 2),
            new Question("Which one is a programming language?", new List<string>{"HTML", "CSS", "C#", "MS Word"}, 2),
            new Question("Which device is used to input data?", new List<string>{"Monitor", "Mouse", "Speaker", "Printer"}, 1),
            new Question("What does CPU stand for?", new List<string>{"Central Processing Unit", "Computer Power Unit", "Central Program Unit", "Control Process Unit"}, 0),
            new Question("Which one is used to store data permanently?", new List<string>{"RAM", "ROM", "Cache", "Registers"}, 1)
        };



        Random rnd = new Random();
        List<Question> selectedQuestions = new List<Question>();

        while (selectedQuestions.Count < 3)
        {
            int index = rnd.Next(questions.Count);
            if (!selectedQuestions.Contains(questions[index]))
            {
                selectedQuestions.Add(questions[index]);
            }
        }

        
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!\n");

        foreach (var q in selectedQuestions)
        {
            q.Display();
            Console.Write("Enter your choice (1-4): ");
            int userInput;

            bool valid = int.TryParse(Console.ReadLine(), out userInput);

            if (valid && userInput >= 1 && userInput <= 4)
            {
                if (q.CheckAnswer(userInput))
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Moving to next question.\n");
            }
        }

        Console.WriteLine($"Quiz Over! You scored {score} out of 3.");
    }
}*/
