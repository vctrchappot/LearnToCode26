using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace _08_arrays_proj;

class Program
{
    private static void Main(string[] args)
    {
        var array = GenerateRandomIntArray(); // Rufe Methode auf, um beliebig langer zufälliger Array zu generieren und speichern.

        var resizedArray = ArrayResizer(array);
        Console.WriteLine(string.Join(", ", resizedArray));
        
        // var sorted = AscendingSorter(array);
        // Console.WriteLine(string.Join(", ", sorted));

        // var counted = SumArrays(array);
        // Console.WriteLine($"Die Summe aller Zahlen im Array lautet {counted}.");

        // var multiplied = IntegerMultiplier(array);
        // Console.WriteLine(string.Join(", ", multiplied));

        // var reversed = ReverseArray(array);
        // Console.WriteLine(string.Join(", ", reversed));
    }

    private static int[] GenerateRandomIntArray()
    {
        Console.WriteLine("Wieviele zufällige Zahlen möchtest du generieren?:");
        var amountOfNumbers = int.Parse(Console.ReadLine());
        
        return Enumerable.Range(0, amountOfNumbers).Select(_ => Random.Shared.Next(0, 100)).ToArray();
    }

    private static int SumArrays(int[] array)
    {
        var sum = 0;

        foreach (var i in array)
        {
            sum = i + sum;
        }

        return sum;
    }

    private static int[] ReverseArray(int[] array)
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

        for (var currentIndex = 0; currentIndex < sorted.Length; currentIndex++)
        {
            for (var comparisonIndex = currentIndex + 1;
                 comparisonIndex < sorted.Length;
                 comparisonIndex++)
            {
                if (sorted[currentIndex] > sorted[comparisonIndex])
                {
                    (sorted[currentIndex], sorted[comparisonIndex]) = (sorted[comparisonIndex], sorted[currentIndex]);
                }
            }
        }

        return sorted;
    }

    private static int[] ArrayResizer(int[] array)
    {
        var resizedArray = new int[array.Length +1];

        Console.WriteLine("Welche Zahl möchtest du dem Array hinzufügen?");
        var x = int.Parse(Console.ReadLine());

        resizedArray[^1] = x;

        return resizedArray;
    }
}