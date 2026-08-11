namespace FirstSteps;

static class Program
{
    public static void Main(string[] args)
    {
        var arguments = string.Join(",", args);
        Console.WriteLine($"Here comes the arguments: {arguments}");
    }
}
