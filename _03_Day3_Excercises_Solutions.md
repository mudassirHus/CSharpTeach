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
// 21. Check if a number is positive, negative or zero
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        int parsedNumber = int.Parse(number);
        if (parsedNumber > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (parsedNumber < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }
}

// 22. Find the largest of three numbers
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        string firstNumber = Console.ReadLine();
        int parsedFirstNumber = int.Parse(firstNumber);

        Console.WriteLine("Enter second number: ");
        string secondNumber = Console.ReadLine();
        int parsedSecondNumber = int.Parse(secondNumber);

        Console.WriteLine("Enter third number: ");
        string thirdNumber = Console.ReadLine();
        int parsedThirdNumber = int.Parse(thirdNumber);

        if (parsedFirstNumber >= parsedSecondNumber && parsedFirstNumber >= parsedThirdNumber)
        {
            Console.WriteLine("The largest number is: " + parsedFirstNumber);
        }
        else if (parsedSecondNumber >= parsedFirstNumber && parsedSecondNumber >= parsedThirdNumber)
        {
            Console.WriteLine("The largest number is: " + parsedSecondNumber);
        }
        else
        {
            Console.WriteLine("The largest number is: " + parsedThirdNumber);
        }
    }
}

// 23. Find the smallest of three numbers
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number 1 : ");
        string number1 = Console.ReadLine();
        int ParseNumber1 = int.Parse(number1);

        Console.Write("Enter number 2 : ");
        string number2 = Console.ReadLine();
        int ParseNumber2 = int.Parse(number2);

        Console.Write("Enter number 3 : ");
        string number3 = Console.ReadLine();
        int ParseNumber3 = int.Parse(number3);

        if (ParseNumber1 < ParseNumber2 && ParseNumber1 < ParseNumber3)
        {
            Console.WriteLine(ParseNumber1 + " is Smallest Number");
        }
        else if (ParseNumber2 < ParseNumber1 && ParseNumber2 < ParseNumber3)
        {
            Console.WriteLine(ParseNumber2 + " is Smallest Number");
        }
        else
        {
            Console.WriteLine(ParseNumber3 + " is Smallest Number");
        }
    }
}

// 24. Check divisibility by 2 or 3
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        int ParseNumber = int.Parse(number);

        if (ParseNumber % 2 == 0)
        {
            Console.WriteLine("It is dvisible by 2.");
        }
        else if (ParseNumber % 3 == 0)
        {
            Console.WriteLine("It is divisible by 3.");
        }
        else if (ParseNumber % 2 == 0 && ParseNumber % 3 == 0)
        {
            Console.WriteLine("It is divisible by 2 and 3.");
        }
        else
        {
            Console.WriteLine("It is neither divisible by 2 nor 3.");
        }
    }
}

// 25. Categorize age (Child, Teen, Adult, Senior)
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter age : ");
        string age = Console.ReadLine();

        int ParseAge = int.Parse(age);

        if (ParseAge >= 1 && ParseAge <= 12)
        {
            Console.WriteLine("Child");
        }
        else if (ParseAge >= 13 && ParseAge <= 17)
        {
            Console.WriteLine("Teen");
        }
        else if (ParseAge >= 18 && ParseAge <= 39)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior");
        }
    }
}

// 26. Display grade based on marks
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Marks : ");
        string marks = Console.ReadLine();

        int ParseMarks = int.Parse(marks);

        if (ParseMarks >= 90)
        {
            Console.WriteLine("Grade - A");
        }
        else if (ParseMarks <= 89 && ParseMarks >= 80)
        {
            Console.WriteLine("Grade - B");
        }
        else if (ParseMarks <= 79 && ParseMarks >= 60)
        {
            Console.WriteLine("Grade - C");
        }
        else if (ParseMarks <= 69 && ParseMarks >= 40)
        {
            Console.WriteLine("Grade - D");
        }
        else
        {
            Console.WriteLine("Grade - F");
        }
    }
}

// 27. Display performance (Excellent, Good, Average, Poor)
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Marks : ");
        string marks = Console.ReadLine();

        int ParseMarks = int.Parse(marks);

        if (ParseMarks >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (ParseMarks <= 89 && ParseMarks >= 60)
        {
            Console.WriteLine("Good");
        }
        else if (ParseMarks <= 59 && ParseMarks >= 50)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Poor");
        }
    }
}

// 28. Distinction, Good or Bad based on marks
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks : ");
        string marks = Console.ReadLine();

        int ParseMarks = int.Parse(marks);

        if(ParseMarks >= 90)
        {
            Console.WriteLine(ParseMarks + " is Distinction.");
        }
        else if (ParseMarks <= 89 && ParseMarks >= 60)
        {
            Console.WriteLine(ParseMarks + " is Good.");
        }
        else
        {
            Console.WriteLine(ParseMarks + " is Bad.");
        }
    }
}

// 29. Class based on percentage
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Percentage : ");
        string percentage = Console.ReadLine();
        int ParsePercentage = int.Parse(percentage);
        if (ParsePercentage >= 70)
        {
            Console.WriteLine(ParsePercentage + "% is First Class.");
        }
        else if (ParsePercentage <= 69 && ParsePercentage >= 50)
        {
            Console.WriteLine(ParsePercentage + "% is Second Class.");
        }
        else if (ParsePercentage <= 49 && ParsePercentage >= 40)
        {
            Console.WriteLine(ParsePercentage + "% is Pass Class.");
        }
        else
        {
            Console.WriteLine(ParsePercentage + "% is Fail.");
        }
    }
}

// 30. Scholarship eligibility based on percentage
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Student's Percentage : ");
        string percentage = Console.ReadLine();
        int ParsePercentage = int.Parse(percentage);
        if (ParsePercentage >= 85)
        {
            Console.WriteLine("Eligible for Full Scholarship.");
        }
        else if (ParsePercentage <= 84 && ParsePercentage >= 70)
        {
            Console.WriteLine("Eligible for Half Scholarship.");
        }
        else if (ParsePercentage <= 69 && ParsePercentage >= 50)
        {
            Console.WriteLine("Eligible for Quarter Scholarship.");
        }
        else
        {
            Console.WriteLine("Not Eligible for Scholarship.");
        }
    }
}

// 31. Check vowel or consonant
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an Alphabet : ");
        char alphabet = Console.ReadLine()[0];
        if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' ||
            alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
        {
            Console.WriteLine(alphabet + " is a Vowel.");
        }
        else
        {
            Console.WriteLine(alphabet + " is Consonant.");
        }
    }
}

// 32. Check alphabet, digit or special symbol
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Character : ");
        char character = Console.ReadLine()[0];
        if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
        {
            Console.WriteLine(character + " is an Alphabet.");
        }
        else if (character >= '0' && character <= '9')
        {
            Console.WriteLine(character + " is a Digit.");
        }
        else
        {
            Console.WriteLine(character + " is a Special Symbol.");
        }
    }
}

// 33. Check weekday or weekend
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Day Name : ");
        string dayName = Console.ReadLine().ToLower();
        if (dayName == "saturday" || dayName == "sunday")
        {
            Console.WriteLine(dayName + " is a Weekend.");
        }
        else if (dayName == "monday" || dayName == "tuesday" || dayName == "wednesday" ||
                 dayName == "thursday" || dayName == "friday")
        {
            Console.WriteLine(dayName + " is a Weekday.");
        }
        else
        {
            Console.WriteLine(dayName + " is an Invalid Day Name.");
        }
    }
}

// 34. Display time of day based on hour
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Hour of the Day (0-23) : ");
        string hourInput = Console.ReadLine();
        int hour = int.Parse(hourInput);
        if (hour >= 5 && hour < 12)
        {
            Console.WriteLine("Morning");
        }
        else if (hour >= 12 && hour < 17)
        {
            Console.WriteLine("Afternoon");
        }
        else if (hour >= 17 && hour < 21)
        {
            Console.WriteLine("Evening");
        }
        else if ((hour >= 21 && hour <= 23) || (hour >= 0 && hour < 5))
        {
            Console.WriteLine("Night");
        }
        else
        {
            Console.WriteLine("Invalid Hour Input.");
        }
    }
}

// 35. Traffic light action
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Traffic Light Color (red/yellow/green) : ");
        string color = Console.ReadLine().ToLower();
        if (color == "red")
        {
            Console.WriteLine("Stop");
        }
        else if (color == "yellow")
        {
            Console.WriteLine("Get Ready");
        }
        else if (color == "green")
        {
            Console.WriteLine("Go");
        }
        else
        {
            Console.WriteLine("Invalid Traffic Light Color.");
        }
    }
}
