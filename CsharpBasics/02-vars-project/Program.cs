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
        string name = "Victor";

        string agename = name + ", " + age;
        Console.WriteLine(agename);
    }

    static void piEulerNumber()
    {
        const float piFloat = 3;
        const double piDouble = 0.14159;
        Console.WriteLine("Die ersten sechs Ziffern von Pi sind " + (piFloat + piDouble));
    }
}

