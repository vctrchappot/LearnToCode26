using System.Threading.Tasks.Dataflow;

namespace _08_arrays_proj;

class Program
{
    static void Main(string[] args)
    {
        var array = GenerateRandom();
        var goon = ArrayCounter(array);
        Console.WriteLine(goon);
    }

    static int[] GenerateRandom()
    {
        Console.WriteLine("Wieviele zufällige Zahlen möchtest du generieren?:");
        var amountOfNumbers = int.Parse(Console.ReadLine());
        
        var randomNumber = Enumerable.Range(0, amountOfNumbers).Select(_ => Random.Shared.Next(0, 100)).ToArray();

        return randomNumber;
    }

    public static int ArrayCounter(int[] array)
    {
        var sum = 0;

        foreach (var VARIABLE in array)
        {
            sum = VARIABLE + sum;
        }

        return sum;
    }
}