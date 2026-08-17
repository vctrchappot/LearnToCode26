using System;

namespace Debugging_Tutotial_1
{
    class ArrayExample
    {
        static void Main()
        {
            char[] letters = {'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h'};
            var name = "";
            var a = new int[10];
            for (var i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }

            Console.ReadKey();
        }

        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }
    }
}