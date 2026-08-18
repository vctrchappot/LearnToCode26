namespace  _06_oop_project;

public class Program
{
    static void Main()
    {
        var mainAccount = new BankAccount();
        var secondAccount = new BankAccount();
        var thirdAccount = new BankAccount();

        // BankAccount.CurrentBalanceReader(mainAccount, secondAccount, thirdAccount);
        BankAccount.Transfer(mainAccount,secondAccount,thirdAccount);
        //var newBalance = BankAccount.ChangeAccountBalance(mainAccount.balance);
        //Console.WriteLine($"Your new Balance is {newBalance}");
    }
    
    public static void HelloWorldInput()
    {
        Console.WriteLine("Hallo, wie lautet dein Name?");
        var userName = Console.ReadLine();
        
        Console.WriteLine($"Hallo, {userName}!");
    }
    
    public static void IsBiggerInteger()
    {
        var firstNumber = 0;
        var secondNumber = 0;
        
        Console.WriteLine("Erste Zahl:");
        firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Zweite Zahl:");
        secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"{firstNumber} ist grösser als {secondNumber}.");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine($"{firstNumber} ist kleiner als {secondNumber}.");
        }
        else
        {
            Console.WriteLine($"{firstNumber} ist gleich gross wie {secondNumber}.");
        }
    }

    public static void AmountOfSpaces()
    {
        var userInput = Console.ReadLine();

        var amount = 0;

        foreach (var singleCharacter in userInput)
        {
            if (singleCharacter == ' ')
            {
                amount++;
            }
        }
        
        Console.WriteLine($"Du hast {amount} Abstände eingegeben.");
    }
} 

public class BankAccount
{
    public int Balance;

    public BankAccount()
    {
        Balance = 3000;
    }
    
    public static void Transfer(BankAccount acc1, BankAccount acc2, BankAccount acc3)
    {
        var transferAmount = 0;
        
        var sendingBankAccount = new BankAccount();
        var recievingBankAccount = new BankAccount();        
        
        Console.WriteLine("Von welchem Account aus möchtest du Geld überweisen?");
        var firstUserInput = int.Parse(Console.ReadLine());

        switch (firstUserInput)
        {
            case 1:
                sendingBankAccount = acc1;
                break;
            case 2:
                sendingBankAccount = acc2;
                break;
            case 3:
                sendingBankAccount = acc3;
                break;
            default:
                Console.WriteLine("Bitte gib einen gültigen Account ein!");
                return;
        }
        
        Console.WriteLine("Auf welchem Account aus möchtest du Geld überweisen?");
        if (!int.TryParse(Console.ReadLine(), out var secondUserInput))
        {
            Console.WriteLine("Bitte gib einen gültigen Account ein!");
        }

        switch (secondUserInput)
        {
            case 1:
                recievingBankAccount = acc1;
                break;
            case 2:
                recievingBankAccount = acc2;
                break;
            case 3:
                recievingBankAccount = acc3;
                break;
            default:
                Console.WriteLine("Bitte gib einen gültigen Account ein!");
                return;
        }

        if (sendingBankAccount == recievingBankAccount)
        {
            Console.WriteLine("Du kannst dir selbst kein Geld übertragen!");
            return;
        }
        
        Console.WriteLine("Wie viel Geld möchtest du übertragen?");
        if (!int.TryParse(Console.ReadLine(), out transferAmount))
        {
            Console.WriteLine("Bitte gib einen gültigen Betrag ein!");
        }

        var saldo = sendingBankAccount.Balance - transferAmount;
        bool paymentSuccess;

        if (saldo > 0)
        {
            recievingBankAccount.Balance += transferAmount;
            sendingBankAccount.Balance -= transferAmount;
            
            paymentSuccess = true;
        }
        else
        {
            Console.WriteLine($"Transaktion fehlgeschlagen: Balance zu klein! Du benötigst weitere {decimal.Negate(saldo)}.");
            paymentSuccess = false;
        }

        if (!paymentSuccess) return;
        Console.WriteLine($"The account balance for first Account is : {sendingBankAccount.Balance}");
        Console.WriteLine($"The account balance for Second Account is : {recievingBankAccount.Balance}");
    }

    public static int ChangeAccountBalance(int localBalance)
    {
        var newBalance = localBalance;
        
        Console.WriteLine("Bitte gib den Betrag ein:");
        var amountToChange = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Möchtest du diesen Betrag von deinem Account (1)abziehen oder (2)hinzufügen?");
        var transactionChoice = int.Parse(Console.ReadLine());
        newBalance = transactionChoice switch
        {
            1 => localBalance - amountToChange,
            2 => localBalance + amountToChange,
            _ => newBalance
        };

        return newBalance;
    }

    public static int CurrentBalanceReader(BankAccount acc1, BankAccount acc2, BankAccount acc3)
    {
        Console.WriteLine("Which account do you wanna use 1-3");
        int.TryParse(Console.ReadLine(), out var userSelection);
        switch (userSelection)
        {
            case 1:
                Console.WriteLine($"Deine aktuelle Balance beläuft sich auf {acc1.Balance}");
                return acc1.Balance;
            case 2:
                Console.WriteLine($"Deine aktuelle Balance beläuft sich auf {acc2.Balance}");
                return acc1.Balance;
            case 3:
                Console.WriteLine($"Deine aktuelle Balance beläuft sich auf {acc3.Balance}");
                return acc1.Balance;
            default:
                Console.WriteLine("Diesen Account gibt es nicht! Probier nochmals");
                return 404;
        }
    }
}