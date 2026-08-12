namespace _03_operators_project;

class Program
{
    static void Main(string[] args)
    {
        CalculateRemainder();
    }

    static void CalculateFirstResult()
    {
        int x = 60;
        int y = (x + x) * 5;

        Console.WriteLine(y);
    }

    static void CalculateRemainder()
    {
        var x = 0;
        var y = 0;
        
        Console.WriteLine("Whats your first number?");
        int.TryParse(Console.ReadLine(), out x);
        
        Console.WriteLine("Whats your second number?");
        int.TryParse(Console.ReadLine(), out y);

        var z = x % y;
        
        Console.WriteLine("Es bleiben " + z + " übrig.");

    }
}

// Alle Antworten zu den Fragen in https://confdg.atlassian.net/wiki/pages/resumedraft.action?draftId=171999269599