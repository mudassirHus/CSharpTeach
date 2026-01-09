// 1. Check if a number is positive
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 0)
            Console.WriteLine(number + " is Positive");
    }
}

// 2. Check if a number is negative
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the value of number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) < 0)
            Console.WriteLine(number + " is Negative");
    }
}

// 3. Check if a number is zero
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) == 0)
            Console.WriteLine(number + " is Zero");
    }
}

// 4. Check if a number is greater than 100
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 100)
            Console.WriteLine(number + " is greater than 100");
    }
}

// 5. Check if a number is even
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 2 == 0)
            Console.WriteLine(number + "is Even");
    }
}

// 6. Check if a number is odd
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 2 == 1)
            Console.WriteLine(number + " is Odd");
    }
}

// 7. Check if a character is a vowel
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Character : ");
        string character = Console.ReadLine();

        char firstCharacter = character[0];

        if (firstCharacter == 'A')
            Console.WriteLine(firstCharacter + " is Vowel");
        if (firstCharacter == 'E')
            Console.WriteLine(firstCharacter + " is Vowel");
        if (firstCharacter == 'I')
            Console.WriteLine(firstCharacter + " is Vowel");
        if (firstCharacter == 'O')
            Console.WriteLine(firstCharacter + " is Vowel");
        if (firstCharacter == 'U')
            Console.WriteLine(firstCharacter + " is Vowel");
    }
}

// 8. Check voting eligibility (age >= 18)
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Age : ");
        string age = Console.ReadLine();

        if (int.Parse(age) >= 18)
            Console.WriteLine(age + " is Eligible for Vote");
    }
}

// 9. Check if a number is divisible by 5
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 5 == 0)
            Console.WriteLine(number + " is Divisible by 5");
    }
}

// 10. Check if a year is divisible by 4
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Year : ");
        string year = Console.ReadLine();

        if (int.Parse(year) % 4 == 0)
            Console.WriteLine(year + " is Divisible by 4");
    }
}
