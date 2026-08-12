using System.ComponentModel.Design;

namespace _05_loops_project;

class Program {
    static void Main(string[] args)
    {
        RunQuiz();
    }

    static void CalculateSum()
    {
        var sum = 0;
    
        for (var count = 1; count <= 10; count++)
        {
            sum += count;
        }
    
        Console.WriteLine($"Die Summe ist: {sum}");
    }
    
    static void CalculateEvenSum()
    {
        var sum = 0;

        for (var count = 1; count <= 10; count++ )
        {
            if (count % 2 == 0)
            {
                sum += count;
            }
        }
        Console.WriteLine($"Die Summe aller geraden Zahlen ist: {sum}");
    }

    static void PrintPyramid()
    {
        var totalFloors = 1;

        Console.WriteLine("Wie viele Stockwerke soll die Pyramide haben?");
        int.TryParse(Console.ReadLine(), out totalFloors);

        for (var currentFloor = 1; currentFloor <= totalFloors; currentFloor++)
        {
            for (var spacesRemaining = totalFloors - currentFloor; spacesRemaining > 0; spacesRemaining--)
            {
                Console.Write(" ");
            }

            for (var starsRemaining = currentFloor; starsRemaining > 0; starsRemaining--)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }

    static void RunQuiz()
    {
        var quizPassed = false;
        var quizAnswer = 3;
        
        while (quizPassed == false)
        {
            Console.WriteLine("Welcher dieser Firmen produziert keine Grafikkarten für Consumer PCs:");
            Console.WriteLine("- 1) Nvidia, - 2) AMD, - 3) Apple, - 4) Intel                        ");

            if (int.TryParse(Console.ReadLine(), out var userAnswer))
            {
                switch (userAnswer)
                {
                    case 1:
                        Console.WriteLine("Das ist leider die falsche Antwort, versuche es gerne erneut!");
                        break;
                    case 2:
                        Console.WriteLine("Das ist leider die falsche Antwort, versuche es gerne erneut!");
                        break;
                    case 3:
                        Console.WriteLine("Glückwunsch! Dies ist die korrekte Antwort.");
                        quizPassed = true;
                        break;
                    case 4:
                        Console.WriteLine("Das ist leider die falsche Antwort, versuche es gerne erneut!");
                        break;
                    default:
                        Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 4 ein!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl zwischen 1 und 4 ein!");
            }
        }
    }
}