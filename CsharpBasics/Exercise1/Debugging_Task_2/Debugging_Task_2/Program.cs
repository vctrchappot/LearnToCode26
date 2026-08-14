using System;

namespace Debugging_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gewünschtes Verhalten: 2000000000 und 1000000000 addiert und 3000000000 wird in die Konsole geschrieben
            var x = 2000000000u;               
            var y = 1000000000u;               
            var z = x + y;                
            Console.WriteLine(z);                
        }
    }
}