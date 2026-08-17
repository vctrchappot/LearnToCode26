using System.Threading.Tasks.Dataflow;

namespace _08_arrays_proj;

class Program
{
    private static void Main(string[] args)
    {
        var array = GenerateRandom();
        var multiplied = IntegerMultiplier(array);
        Console.WriteLine(string.Join(", ", multiplied));

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
        // Erstellt ein neues Array mit genau der gleichen Länge wie das ursprüngliche Array.
        var reversed = new int[array.Length];

        // Gibt an, an welcher Stelle wir im neuen Array gerade etwas speichern.
        // Startet bei 0, also beim ersten Element.
        var reversedIndex = 0;

        // Wir durchlaufen das ursprüngliche Array rückwärts:
        // array.Length - 1 = letzter Index
        // index-- = bei jedem Durchlauf einen Index zurückgehen
        for (var index = array.Length - 1; index >= 0; index--)
        {
            // Das aktuelle Element aus dem ursprünglichen Array
            // wird an der nächsten freien Stelle im neuen Array gespeichert.
            reversed[reversedIndex++] = array[index];
        
            // reversedIndex++ bedeutet:
            // Erst den aktuellen Wert verwenden, danach um 1 erhöhen.
        }

        // Gibt das neu erstellte, umgekehrte Array zurück.
        return reversed;
    }

    private static int[] IntegerMultiplier(int[] array)
    {
        var multiplied = new int[array.Length];
        var index = 0;

        foreach (int number in array)
        {
            multiplied[index] = number * number;
            index++;
        }

        return multiplied;
    }
}