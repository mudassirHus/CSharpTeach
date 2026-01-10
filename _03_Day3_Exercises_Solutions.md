# C# Conditional Statements Programs (1–48)

---

## 1. Check if a number is positive

```csharp
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
```

---

## 2. Check if a number is negative

```csharp
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
```

---

## 3. Check if a number is zero

```csharp
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
```

---

## 4. Check if a number is greater than 100

```csharp
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
```

---

## 5. Check if a number is even

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 2 == 0)
            Console.WriteLine(number + " is Even");
    }
}
```

---

## 6. Check if a number is odd

```csharp
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
```

---

## 7. Check if a character is a vowel

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Character : ");
        char ch = Console.ReadLine()[0];

        if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            Console.WriteLine(ch + " is Vowel");
    }
}
```

---

## 8. Check voting eligibility

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Age : ");
        string age = Console.ReadLine();

        if (int.Parse(age) >= 18)
            Console.WriteLine("Eligible for Vote");
    }
}
```

---

## 9. Check if number is divisible by 5

```csharp
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
```

---

## 10. Check if year is divisible by 4

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Year : ");
        string year = Console.ReadLine();

        if (int.Parse(year) % 4 == 0)
            Console.WriteLine(year + " is Divisible by 4");
    }
}
```

---

## 11. Check even or odd (if–else)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}
```

---

## 12. Check positive or negative

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 0)
            Console.WriteLine("+ve");
        else
            Console.WriteLine("-ve");
    }
}
```

---

## 13. Pass or Fail

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks : ");
        string marks = Console.ReadLine();

        if (int.Parse(marks) >= 40)
            Console.WriteLine("Pass");
        else
            Console.WriteLine("Fail");
    }
}
```

---

## 14. Greater than 50

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 50)
            Console.WriteLine("Greater than 50");
        else
            Console.WriteLine("Not greater than 50");
    }
}
```

---

## 15. Uppercase or Lowercase

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Character : ");
        char ch = Console.ReadLine()[0];

        if (ch >= 'A' && ch <= 'Z')
            Console.WriteLine("Uppercase");
        else
            Console.WriteLine("Lowercase");
    }
}
```

---

## 16. Divisible by 3

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();

        if (int.Parse(number) % 3 == 0)
            Console.WriteLine("Divisible by 3");
        else
            Console.WriteLine("Not divisible by 3");
    }
}
```

---

## 17. Adult or Minor

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Age : ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("Adult");
        else
            Console.WriteLine("Minor");
    }
}
```

---

## 18. Two numbers equal or not

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a == b)
            Console.WriteLine("Equal");
        else
            Console.WriteLine("Not Equal");
    }
}
```

---

## 19. Leap Year

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}
```

---

## 20. Hot or Cold

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int temp = int.Parse(Console.ReadLine());

        if (temp >= 30)
            Console.WriteLine("Hot");
        else
            Console.WriteLine("Cold");
    }
}
```

---

## 21. Check if a number is positive, negative or zero

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
```

---

## 22. Find the largest of three numbers

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
            Console.WriteLine(a + " is Largest");
        else if (b >= a && b >= c)
            Console.WriteLine(b + " is Largest");
        else
            Console.WriteLine(c + " is Largest");
    }
}
```

---

## 23. Find the smallest of three numbers

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a <= b && a <= c)
            Console.WriteLine(a + " is Smallest");
        else if (b <= a && b <= c)
            Console.WriteLine(b + " is Smallest");
        else
            Console.WriteLine(c + " is Smallest");
    }
}
```

---

## 24. Check divisibility by 2 or 3

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0 && number % 3 == 0)
            Console.WriteLine("Divisible by 2 and 3");
        else if (number % 2 == 0)
            Console.WriteLine("Divisible by 2");
        else if (number % 3 == 0)
            Console.WriteLine("Divisible by 3");
        else
            Console.WriteLine("Not divisible by 2 or 3");
    }
}
```

---

## 25. Categorize age (Child, Teen, Adult, Senior)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        if (age <= 12)
            Console.WriteLine("Child");
        else if (age <= 17)
            Console.WriteLine("Teen");
        else if (age <= 59)
            Console.WriteLine("Adult");
        else
            Console.WriteLine("Senior");
    }
}
```

---

## 26. Display grade based on marks

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 90)
            Console.WriteLine("Grade A");
        else if (marks >= 80)
            Console.WriteLine("Grade B");
        else if (marks >= 60)
            Console.WriteLine("Grade C");
        else if (marks >= 40)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Grade F");
    }
}
```

---

## 27. Display performance

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 90)
            Console.WriteLine("Excellent");
        else if (marks >= 60)
            Console.WriteLine("Good");
        else if (marks >= 50)
            Console.WriteLine("Average");
        else
            Console.WriteLine("Poor");
    }
}
```

---

## 28. Distinction, Good or Bad

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 90)
            Console.WriteLine("Distinction");
        else if (marks >= 60)
            Console.WriteLine("Good");
        else
            Console.WriteLine("Bad");
    }
}
```

---

## 29. Class based on percentage

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 70)
            Console.WriteLine("First Class");
        else if (percentage >= 50)
            Console.WriteLine("Second Class");
        else if (percentage >= 40)
            Console.WriteLine("Pass Class");
        else
            Console.WriteLine("Fail");
    }
}
```

---

## 30. Scholarship eligibility

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 85)
            Console.WriteLine("Full Scholarship");
        else if (percentage >= 70)
            Console.WriteLine("Half Scholarship");
        else if (percentage >= 50)
            Console.WriteLine("Quarter Scholarship");
        else
            Console.WriteLine("No Scholarship");
    }
}
```

---

## 31. Check vowel or consonant

```csharp
class Program
{
    public static void Main(string[] args)
    {
        char ch = char.ToLower(Console.ReadLine()[0]);

        if ("aeiou".Contains(ch))
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
    }
}
```

---

## 32. Alphabet, digit or special character

```csharp
class Program
{
    public static void Main(string[] args)
    {
        char ch = Console.ReadLine()[0];

        if (char.IsLetter(ch))
            Console.WriteLine("Alphabet");
        else if (char.IsDigit(ch))
            Console.WriteLine("Digit");
        else
            Console.WriteLine("Special Character");
    }
}
```

---

## 33. Weekday or Weekend

```csharp
class Program
{
    public static void Main(string[] args)
    {
        string day = Console.ReadLine().ToLower();

        if (day == "saturday" || day == "sunday")
            Console.WriteLine("Weekend");
        else
            Console.WriteLine("Weekday");
    }
}
```

---

## 34. Time of the day

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());

        if (hour >= 5 && hour < 12)
            Console.WriteLine("Morning");
        else if (hour < 17)
            Console.WriteLine("Afternoon");
        else if (hour < 21)
            Console.WriteLine("Evening");
        else
            Console.WriteLine("Night");
    }
}
```

---

## 35. Traffic light action

```csharp
class Program
{
    public static void Main(string[] args)
    {
        string color = Console.ReadLine().ToLower();

        if (color == "red")
            Console.WriteLine("Stop");
        else if (color == "yellow")
            Console.WriteLine("Ready");
        else if (color == "green")
            Console.WriteLine("Go");
        else
            Console.WriteLine("Invalid");
    }
}
```

---

## 36. Display day name using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Invalid Day"); break;
        }
    }
}
```

---

## 37. Display month name using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1: Console.WriteLine("January"); break;
            case 2: Console.WriteLine("February"); break;
            case 3: Console.WriteLine("March"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("June"); break;
            case 7: Console.WriteLine("July"); break;
            case 8: Console.WriteLine("August"); break;
            case 9: Console.WriteLine("September"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
            default: Console.WriteLine("Invalid Month"); break;
        }
    }
}
```

---

## 38. Simple calculator using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];

        switch (op)
        {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/': Console.WriteLine(b != 0 ? a / b : 0); break;
            default: Console.WriteLine("Invalid Operator"); break;
        }
    }
}
```

---

## 39. Number to word (1–5)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            default: Console.WriteLine("Out of Range"); break;
        }
    }
}
```

---

## 40. Check vowel using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        char ch = char.ToLower(Console.ReadLine()[0]);

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }
}
```

---

## 41. Banking menu using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int balance = 50000;
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.WriteLine(balance); break;
            case "2": Console.WriteLine("Deposit"); break;
            case "3": Console.WriteLine("Withdraw"); break;
            case "4": Console.WriteLine("Exit"); break;
            default: Console.WriteLine("Invalid"); break;
        }
    }
}
```

---

## 42. Grade description using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        char grade = char.ToUpper(Console.ReadLine()[0]);

        switch (grade)
        {
            case 'A': Console.WriteLine("Excellent"); break;
            case 'B': Console.WriteLine("Very Good"); break;
            case 'C': Console.WriteLine("Good"); break;
            case 'D': Console.WriteLine("Pass"); break;
            case 'F': Console.WriteLine("Fail"); break;
            default: Console.WriteLine("Invalid Grade"); break;
        }
    }
}
```

---

## 43. Traffic signal using switch

```csharp
class Program
{
    public static void Main(string[] args)
    {
        string color = Console.ReadLine().ToLower();

        switch (color)
        {
            case "red": Console.WriteLine("Stop"); break;
            case "yellow": Console.WriteLine("Ready"); break;
            case "green": Console.WriteLine("Go"); break;
            default: Console.WriteLine("Invalid"); break;
        }
    }
}
```

---

## 44. Season based on month

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 3:
            case 4:
            case 5:
            case 6: Console.WriteLine("Summer"); break;
            case 7:
            case 8:
            case 9:
            case 10: Console.WriteLine("Rainy"); break;
            default: Console.WriteLine("Winter"); break;
        }
    }
}
```

---

## 45. Greater of two numbers (ternary)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a > b ? a + " is Greater" : b + " is Greater");
    }
}
```

---

## 46. Smallest of three numbers (ternary)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int smallest = (a < b) ? ((a < c) ? a : c) : ((b < c) ? b : c);
        Console.WriteLine(smallest);
    }
}
```

---

## 47. Pass or Fail (ternary)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int marks = int.Parse(Console.ReadLine());
        Console.WriteLine(marks >= 40 ? "Pass" : "Fail");
    }
}
```

---

## 48. Age category (ternary)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        string category =
            age < 13 ? "Child" :
            age < 20 ? "Teen" :
            age < 60 ? "Adult" : "Senior";

        Console.WriteLine(category);
    }
}
```
