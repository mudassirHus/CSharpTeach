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

// 11. Check if a number is even or odd
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 2 == 0)
            Console.WriteLine(number + " is Even");
        else
            Console.WriteLine(number + " is  Odd");
    }
}

// 12. Check if a number is positive or negative
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 0)
            Console.WriteLine(number + " is +ve");
        else
            Console.WriteLine(number + " is -ve");
    }
}

// 13. Check pass or fail based on marks
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks : ");
        string marks = Console.ReadLine();
        if (int.Parse(marks) >= 40)
            Console.WriteLine("You are Pass");
        else
            Console.WriteLine("You are Fail");
    }
}

// 14. Check if number is greater than 50
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();
        if (int.Parse(number) > 50)
            Console.WriteLine(number + " is Greater than 50");
        else
            Console.WriteLine(number + " is Not Greater than 50");
    }
}

// 15. Check if character is uppercase or lowercase
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Character : ");
        char character = Console.ReadLine()[0];
        if (character >= 'A' && character <= 'Z')
            Console.WriteLine(character + " is Uppercase Character");
        else
            Console.WriteLine(character + " is Lowercase Character");
    }
}

// 16. Check if number is divisible by 3
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();
        if (int.Parse(number) % 3 == 0)
            Console.WriteLine(number + " is Divisible by 3");
        else
            Console.WriteLine(number + " is Not Divisible by 3");
    }
}

// 17. Check if person is adult or minor
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        string age = Console.ReadLine();

        if (int.Parse(age) >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a minor");
        }
    }
}

// 18. Check if two numbers are equal or not
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter second number: ");
        string secondNumber = Console.ReadLine();
        if (int.Parse(firstNumber) == int.Parse(secondNumber))
        {
            Console.WriteLine("The two numbers are equal");
        }
        else
        {
            Console.WriteLine("The two numbers are not equal");
        }
    }
}

// 19. Check if a year is a leap year
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year: ");
        string year = Console.ReadLine();

        int ParseYr = int.Parse(year);

        if ((ParseYr % 4 == 0) && (ParseYr % 100 != 0 || ParseYr % 400 == 0))
        {
            Console.WriteLine(ParseYr + " is a leap year");
        }
        else
        {
            Console.WriteLine(ParseYr + " is not a leap year");
        }
    }
}

// 20. Check if weather is hot or cold
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature: ");
        string temperature = Console.ReadLine();
        if (int.Parse(temperature) >= 30)
        {
            Console.WriteLine("The weather is hot");
        }
        else
        {
            Console.WriteLine("The weather is cold");
        }
    }
}
