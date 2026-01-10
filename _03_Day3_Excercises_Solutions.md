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
// 36. Display day name using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter day number : ");
        string dayNumber = Console.ReadLine();

        int ParseDayNumber = int.Parse(dayNumber);

        switch(ParseDayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wenesday");
                break;
            case 4:
                Console.WriteLine("Thusday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }
}

// 37. Display month name using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter month number : ");
        string monthNumber = Console.ReadLine();
        int ParseMonthNumber = int.Parse(monthNumber);
        switch (ParseMonthNumber)
        {
            case 1: Console.WriteLine("January"); 
            break;
            case 2: Console.WriteLine("February"); 
            break;
            case 3: Console.WriteLine("March"); 
            break;
            case 4: Console.WriteLine("April"); 
            break;
            case 5: Console.WriteLine("May"); 
            break;
            case 6: Console.WriteLine("June"); 
            break;
            case 7: Console.WriteLine("July"); 
            break;
            case 8: Console.WriteLine("August"); 
            break;
            case 9: Console.WriteLine("September"); 
            break;
            case 10: Console.WriteLine("October"); 
            break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
        }
    }
}

// 38. Simple calculator using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Operator (+, -, *, /): ");
        char operatorChar = Console.ReadLine()[0];

        double result;
        switch (operatorChar)
        {
            case '+': result = num1 + num2; Console.WriteLine("Result: " + result); break;
            case '-': result = num1 - num2; Console.WriteLine("Result: " + result); break;
            case '*': result = num1 * num2; Console.WriteLine("Result: " + result); break;
            case '/':
                if (num2 != 0) { result = num1 / num2; Console.WriteLine("Result: " + result); }
                else { Console.WriteLine("Error: Division by zero is not allowed."); }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }
    }
}

// 39. Number to word (1–5)
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number (1-5) : ");
        string number = Console.ReadLine();
        int ParseNumber = int.Parse(number);
        switch (ParseNumber)
        {
            case 1: Console.WriteLine("One"); 
            break;
            case 2: Console.WriteLine("Two"); 
            break;
            case 3: Console.WriteLine("Three"); 
            break;
            case 4: Console.WriteLine("Four"); 
            break;
            case 5: Console.WriteLine("Five"); 
            break;
            default: Console.WriteLine("Number is out of range (1-5)."); break;
        }
    }
}

// 40. Check vowel using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an alphabet: ");
        char alphabet = Console.ReadLine()[0];
        alphabet = char.ToLower(alphabet);

        switch (alphabet)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("It is a Vowel.");
                break;
            default:
                Console.WriteLine("It is a Consonant.");
                break;
        }
    }
}

// 41. Banking menu using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Banking Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Exit");

        Console.Write("Select an option (1-4): ");
        string choice = Console.ReadLine();

        int currentBalance = 50000;

        switch (choice)
        {
            case "1":
                Console.WriteLine("Your current balance is " + currentBalance);
                break;
            case "2":
                Console.Write("Enter amount to deposit: ");
                string depositAmount = Console.ReadLine();
                Console.WriteLine("You have deposited " + depositAmount);
                break;
            case "3":
                Console.Write("Enter amount to withdraw: ");
                string withdrawAmount = Console.ReadLine();
                if (int.Parse(withdrawAmount) < currentBalance)
                    Console.WriteLine("You have withdrawn " + withdrawAmount);
                else
                    Console.WriteLine("Insufficient balance.");
                break;
            case "4":
                Console.WriteLine("Thank you for using our banking services. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid option selected. Please try again.");
                break;
        }
    }
}

// 42. Grade description using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your grade (A, B, C, D, F): ");
        char grade = Console.ReadLine()[0];
        grade = char.ToUpper(grade);

        switch (grade)
        {
            case 'A': Console.WriteLine("Excellent"); 
            break;
            case 'B': Console.WriteLine("Very Good"); 
            break;
            case 'C': Console.WriteLine("Good"); 
            break;
            case 'D': Console.WriteLine("Pass"); 
            break;
            case 'F': Console.WriteLine("Fail"); 
            break;
            default: Console.WriteLine("Invalid Grade"); 
            break;
        }
    }
}

// 43. Traffic signal action using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter traffic signal color (Red, Yellow, Green): ");
        string signalColor = Console.ReadLine().ToLower();

        switch (signalColor)
        {
            case "red": Console.WriteLine("Stop"); 
            break;
            case "yellow": Console.WriteLine("Get Ready"); 
            break;
            case "green": Console.WriteLine("Go"); 
            break;
            default: Console.WriteLine("Invalid Color"); 
            break;
        }
    }
}

// 44. Season based on month using switch
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter month number (1-12): ");
        string monthInput = Console.ReadLine();
        int monthNumber = int.Parse(monthInput);

        switch (monthNumber)
        {
            case 3:
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Summer");
                break;
            case 7:
            case 8:
            case 9:
            case 10:
                Console.WriteLine("Rainy");
                break;
            case 11:
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;
            default:
                Console.WriteLine("Invalid month number");
                break;
        }
    }
}

// 45. Greater of two numbers using ternary
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1 : ");
        string number1 = Console.ReadLine();

        Console.Write("Enter Number 2 : ");
        string number2 = Console.ReadLine();

        string result = (int.Parse(number1) > int.Parse(number2)) ? (number1 + " is Greater") : (number2 + " is Greater");
        Console.WriteLine(result);
    }
}

// 46. Smallest of three numbers using ternary
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1 : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2 : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 3 : ");
        int num3 = int.Parse(Console.ReadLine());

        int smallest = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);

        Console.WriteLine("The smallest number is " + smallest);
    }
}

// 47. Pass or fail using ternary
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        int marks = int.Parse(Console.ReadLine());

        string result = (marks >= 40) ? "Pass" : "Fail";
        Console.WriteLine("You have " + result);
    }
}

// 48. Age category using ternary
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        string category = (age < 13) ? "Child" :
                          (age >= 13 && age < 20) ? "Teenager" :
                          (age >= 20 && age < 60) ? "Adult" : "Senior Citizen";

        Console.WriteLine("You are classified as: " + category);
    }
}
