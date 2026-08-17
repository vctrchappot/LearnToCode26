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
        // Erstellt ein neues Array mit derselben Länge wie das ursprüngliche Array.
        var reversed = new int[array.Length];

        // Gibt an, an welcher Position im neuen Array
        // das nächste Element gespeichert wird.
        var reversedIndex = 0;

        // Durchläuft das ursprüngliche Array von hinten nach vorne.
        // array.Length - 1 = Index des letzten Elements.
        for (var originalIndex = array.Length - 1;
             originalIndex >= 0;
             originalIndex--)
        {
            // Nimmt das aktuelle Element aus dem ursprünglichen Array
            // und speichert es an der nächsten Position im neuen Array.
            reversed[reversedIndex] = array[originalIndex];

            // Geht zur nächsten freien Position im neuen Array.
            reversedIndex++;
        }

        // Gibt das umgekehrte Array zurück.
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
        // Erstellt eine Kopie des ursprünglichen Arrays,
        // damit wir das Original nicht verändern.
        var sorted = (int[])array.Clone();

        // Wird beim Vertauschen von zwei Werten benötigt.
        var temporaryValue = 0;

        // Geht jedes Element von links nach rechts durch.
        for (var currentIndex = 0; currentIndex < sorted.Length; currentIndex++)
        {
            // Vergleicht das aktuelle Element mit allen Elementen rechts davon.
            for (var comparisonIndex = currentIndex + 1;
                 comparisonIndex < sorted.Length;
                 comparisonIndex++)
            {
                // Ist das aktuelle Element größer als das verglichene Element,
                // stehen sie in der falschen Reihenfolge.
                if (sorted[currentIndex] > sorted[comparisonIndex])
                {
                    // Wert vorübergehend speichern, damit er beim Tauschen
                    // nicht verloren geht.
                    temporaryValue = sorted[currentIndex];

                    // Kleineren Wert nach links verschieben.
                    sorted[currentIndex] = sorted[comparisonIndex];

                    // Ursprünglich größeren Wert nach rechts verschieben.
                    sorted[comparisonIndex] = temporaryValue;
                }
            }
        }

        // Gibt das aufsteigend sortierte Array zurück.
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