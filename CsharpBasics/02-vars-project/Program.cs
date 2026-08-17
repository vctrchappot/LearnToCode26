namespace _02_vars_project;

class Program
{
    static void Main(string[] args)
    {
        piEulerNumber();
    }
    
    static void NameAge()
    {
        byte age = 17;
        var name = "Victor";

        var agename = name + ", " + age;
        Console.WriteLine(agename);
    }

    static void piEulerNumber()
    {
        const double pi = 3.14159;
        Console.WriteLine("Die ersten sechs Ziffern von Pi sind " + pi);
    }
}

