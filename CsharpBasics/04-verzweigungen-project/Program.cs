using System.ComponentModel;
using System.ComponentModel.Design;

namespace _04_verzweigungen_project;

class Program
{
    static void Main(string[] args)
    {
        CompareNumbersConditional();
    }

    static void CompareNumbers()
    {
        var x = 0;
        var y = 0;

        Console.WriteLine("Gib deine erste Zahl ein:");
        int.TryParse(Console.ReadLine(), out x);
        
        Console.WriteLine("Gib deine zweite Zahl ein:");
        int.TryParse(Console.ReadLine(), out y);

        if (x == y)
        {
            Console.WriteLine("Deine Zahlen sind gleich.");
        }
        else
        {
            Console.WriteLine("Deine Zahlen sind nicht gleich.");
        }
    }
    
    static void CheckMultiples()
    {
        var x = 0;
        var y = 0;

        Console.WriteLine("Gib deine erste Zahl ein:");
        int.TryParse(Console.ReadLine(), out x);
        
        Console.WriteLine("Gib deine zweite Zahl ein:");
        int.TryParse(Console.ReadLine(), out y);

        if ((x % y) == 0)
        {
            if (x == y)
            {
                Console.WriteLine("Deine Zahlen sind gleich, sowie ein Vielfaches voneinander.");
            }
            else
            {
                Console.WriteLine("Deine Zahlen nicht gleich, jedoch ein Vielfaches voneinander.");
            }
        }
        else // Checking if multiple of each others
        {
            Console.WriteLine(x + " ist weder ein Vielfaches von " + y + ", noch sind sie gleich.");
        }
    }

    static void SelectColor()
    {
        var color = 0;
        
        Console.WriteLine("Geben Sie eine Farbe ein: 1 = rot, 2 = blau, 3 = grün, 4 = gelb.");
        
        if (int.TryParse(Console.ReadLine(), out color))
        {
            switch (color)
            {
                case 1:
                    Console.WriteLine("Du hast " + color + " eingegeben, welches die Farbe Rot ist.");
                    break;
                case 2:
                    Console.WriteLine("Du hast " + color + " eingegeben, welches die Farbe Blau ist.");
                    break;
                case 3:
                    Console.WriteLine("Du hast " + color + " eingegeben, welches die Farbe Grün ist.");
                    break;
                case 4:
                    Console.WriteLine("Du hast " + color + " eingegeben, welches die Farbe Gelb ist.");
                    break;
                default:
                    Console.WriteLine($"{color} ist keine gültige Farbauswahl!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Bitte gib einen gültigen Zahlenwert ein!");
        }
    }

    static void CompareNumbersConditional()
    {
        var x = 0;
        var y = 0;

        Console.WriteLine("Gib deine erste Zahl ein:");
        if (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Bitte gib eine gültige Zahl ein!");
        }
        else
        {
            Console.WriteLine("Gib deine zweite Zahl ein:");
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein!");
            }
            else
            {
                var isIdentical = y == x ? "Deine Zahlen sind gleich." : "Deine Zahlen nicht gleich.";
                Console.WriteLine(isIdentical);
            }
        }
    }
}