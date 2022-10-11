using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Answer the following questions");

        Console.WriteLine("Who is the current President of the United States?" +
                          "\n A: Barack Obama" +
                          "\n B: Bill Clinton" +
                          "\n C: Joseph Biden");
        char answerQ1 = Convert.ToChar(Console.ReadLine());
        if (answerQ1 == 'C' || answerQ1 == 'c') Console.WriteLine($"{answerQ1} is correct.");
        else Console.WriteLine("You are wrong");

        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("What is the capital of France?" +
                          "\n A: Paris" +
                          "\n B: Marseille" +
                          "\n C: Rennes");
        char answerQ2 = Convert.ToChar(Console.ReadLine());
        if (answerQ2 == 'A' || answerQ2 == 'a') Console.WriteLine($"{answerQ2} is correct.");
        else Console.WriteLine("You are wrong");

        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("What is the largest ocean?" +
                          "\n A: Atlantic Ocean" +
                          "\n B: Indian Ocean" +
                          "\n C: Pacific Ocean");
        char answerQ3 = Convert.ToChar(Console.ReadLine());
        if (answerQ3 == 'C' || answerQ3 == 'c') Console.WriteLine($"{answerQ3} is correct.");
        else Console.WriteLine("You are wrong");

        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();

        int numQuestions = 3;
        int numCorrectAnswers = 0;

        if (answerQ1 == 'C' || answerQ1 == 'c') numCorrectAnswers ++;
        if (answerQ2 == 'A' || answerQ2 == 'a') numCorrectAnswers ++;
        if (answerQ3 == 'c' || answerQ3 == 'c') numCorrectAnswers ++;

        Console.WriteLine($"You have answered {numCorrectAnswers}/{numQuestions} correctly");
    }
}

