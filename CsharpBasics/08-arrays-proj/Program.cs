using System.Threading.Tasks.Dataflow;

namespace _08_arrays_proj;

class Program
{
    private static void Main(string[] args)
    {
        var array = GenerateRandom(); // Rufe Methode auf, um beliebig langer zufälliger Array zu generieren und speichern.
        
        var sorted = AscendingSorter(array);
        Console.WriteLine(string.Join(", ", sorted));

        // var counted = ArrayCounter(array);
        // Console.WriteLine($"Die Summe aller Zahlen im Array lautet {counted}.");

        // var multiplied = IntegerMultiplier(array);
        // Console.WriteLine(string.Join(", ", multiplied));

        // var reversed = ArrayReverser(array);
        // Console.WriteLine(string.Join(", ", reversed));
    }

    private static int[] GenerateRandom()
    {
        Console.WriteLine("Wieviele zufällige Zahlen möchtest du generieren?:");
        var amountOfNumbers = int.Parse(Console.ReadLine());
        
        var randomNumber = Enumerable.Range(0, amountOfNumbers).Select(_ => Random.Shared.Next(0, 100)).ToArray();

        return randomNumber;
    }

    private static int ArrayCounter(int[] array)
    {
        var sum = 0;

        foreach (var variable in array)
        {
            sum = variable + sum;
        }

        return sum;
    }

    private static int[] ArrayReverser(int[] array)
    {
        var reversed = new int[array.Length];
        var reversedIndex = 0;

        for (var originalIndex = array.Length - 1; originalIndex >= 0; originalIndex--)
        {
            reversed[reversedIndex] = array[originalIndex];
            reversedIndex++;
        }

        return reversed;
    }

    private static int[] IntegerMultiplier(int[] array)
    {
        var multiplied = new int[array.Length];
        var index = 0;

        foreach (var number in array)
        {
            multiplied[index] = number * number;
            index++;
        }

        return multiplied;
    }

    private static int[] AscendingSorter(int[] array)
    {
        var sorted = (int[])array.Clone();
        var temporaryValue = 0;

        for (var currentIndex = 0; currentIndex < sorted.Length; currentIndex++)
        {
            for (var comparisonIndex = currentIndex + 1;
                 comparisonIndex < sorted.Length;
                 comparisonIndex++)
            {
                if (sorted[currentIndex] > sorted[comparisonIndex])
                {
                    temporaryValue = sorted[currentIndex];

                    sorted[currentIndex] = sorted[comparisonIndex];
                    sorted[comparisonIndex] = temporaryValue;
                }
            }
        }

        return sorted;
    }

    private static int[] ArrayResizer(int[] array)
    {
        Array.Resize(ref array, array.Length + 1);

        Console.WriteLine("Welche Zahl möchtest du dem Array hinzufügen?");
        var x = int.Parse(Console.ReadLine());

        array[array.Length - 1] = x;

        return array;
    }
}