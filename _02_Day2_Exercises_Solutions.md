# C# Basic Input–Output Programs (1–50)

---

## 1. Ask: Enter your Name → Output: Hello, <name>

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What is Your Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name);
    }
}
```

---

## 2. Ask: Enter your age → Output: You will be <age+1> next year

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What is your Age : ");
        string age = Console.ReadLine();
        Console.WriteLine("Next Year you will be : " + (int.Parse(age) + 1));
    }
}
```

---

## 3. Ask: Enter your city → Output: You live in

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your City : ");
        string city = Console.ReadLine();
        Console.WriteLine("You Live in " + city);
    }
}
```

---

## 4. Ask: Enter your favorite number → Output: Result = number × 2

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Favorite Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Result = " + int.Parse(number) * 2);
    }
}
```

---

## 5. Ask: Enter two numbers → Output: You entered X and Y

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number : ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter Second Number : ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("You entered " + firstNumber + " and " + secondNumber);
    }
}
```

---

## 6. Ask: Enter two numbers → Output: Sum = X + Y

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number : ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter Second Number : ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("Sum = " + (int.Parse(firstNumber) + int.Parse(secondNumber)));
    }
}
```

---

## 7. Ask: Enter two numbers → Output: Difference = X − Y

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number : ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter Second Number : ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("Difference = " + (int.Parse(firstNumber) - int.Parse(secondNumber)));
    }
}
```

---

## 8. Ask: Enter two numbers → Output: Product = X × Y

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Number : ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter Second Number : ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("Product = " + (int.Parse(firstNumber) * int.Parse(secondNumber)));
    }
}
```

---

## 9. Ask: Enter dividend & divisor → Output: Quotient

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Dividend : ");
        string dividend = Console.ReadLine();
        Console.Write("Enter Divisor : ");
        string divisor = Console.ReadLine();
        Console.WriteLine("Quotient = " + (int.Parse(dividend) / int.Parse(divisor)));
    }
}
```

---

## 10. Ask: Enter dividend & divisor → Output: Remainder

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Dividend : ");
        string dividend = Console.ReadLine();
        Console.Write("Enter Divisor : ");
        string divisor = Console.ReadLine();
        Console.WriteLine("Remainder = " + (int.Parse(dividend) % int.Parse(divisor)));
    }
}
```

---

## 11. Ask: Enter a number → Output: Square

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Square = " + (int.Parse(number) * int.Parse(number)));
    }
}
```

---

## 12. Ask: Enter a number → Output: Cube

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Cube = " + (int.Parse(number) * int.Parse(number) * int.Parse(number)));
    }
}
```

---

## 13. Ask: Enter length & width → Output: Rectangle area

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Length : ");
        string length = Console.ReadLine();
        Console.Write("Enter Width : ");
        string width = Console.ReadLine();
        Console.WriteLine("Rectangle Area = " + (int.Parse(length) * int.Parse(width)));
    }
}
```

---

## 14. Ask: Enter base & height → Output: Triangle area

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Base : ");
        string baseLength = Console.ReadLine();
        Console.Write("Enter Height : ");
        string height = Console.ReadLine();
        Console.WriteLine("Triangle Area = " + (0.5 * int.Parse(baseLength) * int.Parse(height)));
    }
}
```

---

## 15. Ask: Enter radius → Output: Circle area (π = 3.14)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Radius : ");
        string radius = Console.ReadLine();
        Console.WriteLine("Circle Area = " + (3.14 * int.Parse(radius) * int.Parse(radius)));
    }
}
```

---

## 16. Ask: Enter monthly salary → Output: Yearly salary

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Monthly Salary : ");
        string monthlySalary = Console.ReadLine();
        Console.WriteLine("Yearly Salary = " + (int.Parse(monthlySalary) * 12));
    }
}
```

---

## 17. Ask: Enter 5 subject marks → Output: Average

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Mark 1 : ");
        string mark1 = Console.ReadLine();
        Console.Write("Enter Mark 2 : ");
        string mark2 = Console.ReadLine();
        Console.Write("Enter Mark 3 : ");
        string mark3 = Console.ReadLine();
        Console.Write("Enter Mark 4 : ");
        string mark4 = Console.ReadLine();
        Console.Write("Enter Mark 5 : ");
        string mark5 = Console.ReadLine();

        double average = (int.Parse(mark1) + int.Parse(mark2) + int.Parse(mark3)
                        + int.Parse(mark4) + int.Parse(mark5)) / 5.0;

        Console.WriteLine("Average = " + average);
    }
}
```

---

## 18. Ask: Enter kilometers → Output: Meters

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Kilometers : ");
        string kilometers = Console.ReadLine();
        Console.WriteLine("Meters = " + (int.Parse(kilometers) * 1000));
    }
}
```

---

## 19. Ask: Enter minutes → Output: Seconds

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Minutes : ");
        string minutes = Console.ReadLine();
        Console.WriteLine("Seconds = " + (int.Parse(minutes) * 60));
    }
}
```

---

## 20. Ask: Enter days → Output: Hours

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Days : ");
        string days = Console.ReadLine();
        Console.WriteLine("Hours = " + (int.Parse(days) * 24));
    }
}
```

---

## 21. Ask: Enter Celsius → Output: Fahrenheit

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Celsius : ");
        string celsius = Console.ReadLine();
        double fahrenheit = (int.Parse(celsius) * 9.0 / 5.0) + 32;
        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }
}
```

---

## 22. Ask: Enter Fahrenheit → Output: Celsius

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Fahrenheit : ");
        string fahrenheit = Console.ReadLine();
        double celsius = (int.Parse(fahrenheit) - 32) * 5.0 / 9.0;
        Console.WriteLine("Celsius = " + celsius);
    }
}
```

---

## 23. Ask: Enter meters → Output: Centimeters

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Meters : ");
        string meters = Console.ReadLine();
        Console.WriteLine("Centimeters = " + (int.Parse(meters) * 100));
    }
}
```

---

## 24. Ask: Enter kilograms → Output: Grams

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Kilograms : ");
        string kilograms = Console.ReadLine();
        Console.WriteLine("Grams = " + (int.Parse(kilograms) * 1000));
    }
}
```

---

## 25. Ask: Enter rupees → Output: Paise

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Rupees : ");
        string rupees = Console.ReadLine();
        Console.WriteLine("Paise = " + (int.Parse(rupees) * 100));
    }
}
```

---

## 26. Ask: Enter hours & rate per hour → Output: Total pay

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Hours Worked : ");
        string hours = Console.ReadLine();
        Console.Write("Enter Rate per Hour : ");
        string rate = Console.ReadLine();
        Console.WriteLine("Total Pay = " + (int.Parse(hours) * int.Parse(rate)));
    }
}
```

---

## 27. Ask: Enter length of side → Output: Area of square

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Side Length : ");
        string side = Console.ReadLine();
        Console.WriteLine("Area of Square = " + (int.Parse(side) * int.Parse(side)));
    }
}
```

---

## 28. Ask: Enter principal, rate, time → Output: Simple interest

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Principal : ");
        string principal = Console.ReadLine();
        Console.Write("Enter Rate : ");
        string rate = Console.ReadLine();
        Console.Write("Enter Time : ");
        string time = Console.ReadLine();
        double si = (int.Parse(principal) * int.Parse(rate) * int.Parse(time)) / 100.0;
        Console.WriteLine("Simple Interest = " + si);
    }
}
```

---

## 29. Ask: Enter monthly saving → Output: Yearly saving

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Monthly Saving : ");
        string monthlySaving = Console.ReadLine();
        Console.WriteLine("Yearly Saving = " + (int.Parse(monthlySaving) * 12));
    }
}
```

---

## 30. Ask: Enter loan & months → Output: EMI

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Loan Amount : ");
        string loan = Console.ReadLine();
        Console.Write("Enter Months : ");
        string months = Console.ReadLine();
        Console.WriteLine("EMI = " + (int.Parse(loan) / int.Parse(months)));
    }
}
```

---

## 31. Ask: Enter number → Output: Last digit

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Last Digit = " + (int.Parse(number) % 10));
    }
}
```

---

## 32. Ask: Enter two-digit number → Output: Sum of digits

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Two-Digit Number : ");
        string number = Console.ReadLine();
        int first = int.Parse(number) / 10;
        int second = int.Parse(number) % 10;
        Console.WriteLine("Sum of Digits = " + (first + second));
    }
}
```

---

## 33. Ask: Enter number → Output: Half

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Half = " + (int.Parse(number) / 2.0));
    }
}
```

---

## 34. Ask: Enter apples → Output: Apples per person (2 people)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Apples : ");
        string apples = Console.ReadLine();
        Console.WriteLine("Apples per Person = " + (int.Parse(apples) / 2.0));
    }
}
```

---

## 35. Ask: Enter seconds → Output: Minutes

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Seconds : ");
        string seconds = Console.ReadLine();
        Console.WriteLine("Minutes = " + (int.Parse(seconds) / 60.0));
    }
}
```

---

## 36. Ask: Enter square side → Output: Perimeter

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Side : ");
        string side = Console.ReadLine();
        Console.WriteLine("Perimeter = " + (4 * int.Parse(side)));
    }
}
```

---

## 37. Ask: Enter length, width, height → Output: Volume

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Length : ");
        string length = Console.ReadLine();
        Console.Write("Enter Width : ");
        string width = Console.ReadLine();
        Console.Write("Enter Height : ");
        string height = Console.ReadLine();
        Console.WriteLine("Volume = " + (int.Parse(length) * int.Parse(width) * int.Parse(height)));
    }
}
```

---

## 38. Ask: Enter diameter → Output: Radius

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Diameter : ");
        string diameter = Console.ReadLine();
        Console.WriteLine("Radius = " + (int.Parse(diameter) / 2.0));
    }
}
```

---

## 39. Ask: Enter speed & time → Output: Distance

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Speed : ");
        string speed = Console.ReadLine();
        Console.Write("Enter Time : ");
        string time = Console.ReadLine();
        Console.WriteLine("Distance = " + (int.Parse(speed) * int.Parse(time)));
    }
}
```

---

## 40. Ask: Enter distance & time → Output: Speed

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Distance : ");
        string distance = Console.ReadLine();
        Console.Write("Enter Time : ");
        string time = Console.ReadLine();
        Console.WriteLine("Speed = " + (int.Parse(distance) / int.Parse(time)));
    }
}
```

---

## 41. Ask: Enter first & last name → Output: Full name

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Name : ");
        string first = Console.ReadLine();
        Console.Write("Enter Last Name : ");
        string last = Console.ReadLine();
        Console.WriteLine("Full Name = " + first + " " + last);
    }
}
```

---

## 42. Ask: Enter birth year → Output: Age (current year = 2025)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Birth Year : ");
        string year = Console.ReadLine();
        Console.WriteLine("Age = " + (2025 - int.Parse(year)));
    }
}
```

---

## 43. Ask: Enter bill & people → Output: Cost per person

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Bill : ");
        string bill = Console.ReadLine();
        Console.Write("Enter People : ");
        string people = Console.ReadLine();
        Console.WriteLine("Cost per Person = " + (int.Parse(bill) / int.Parse(people)));
    }
}
```

---

## 44. Ask: Enter marks & total → Output: Percentage

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks : ");
        string marks = Console.ReadLine();
        Console.Write("Enter Total : ");
        string total = Console.ReadLine();
        double percentage = (int.Parse(marks) / (double)int.Parse(total)) * 100;
        Console.WriteLine("Percentage = " + percentage + "%");
    }
}
```

---

## 45. Ask: Enter price & discount → Output: Final price

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Price : ");
        string price = Console.ReadLine();
        Console.Write("Enter Discount % : ");
        string discount = Console.ReadLine();
        double finalPrice = int.Parse(price) - (int.Parse(price) * int.Parse(discount) / 100.0);
        Console.WriteLine("Final Price = " + finalPrice);
    }
}
```

---

## 46. Ask: Enter hero name & power → Output: Short story line

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Hero Name : ");
        string hero = Console.ReadLine();
        Console.Write("Enter Power : ");
        string power = Console.ReadLine();
        Console.WriteLine(hero + " uses " + power + " to save the day!");
    }
}
```

---

## 47. Ask: Enter score → Output: Score + 100

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Score : ");
        string score = Console.ReadLine();
        Console.WriteLine("New Score = " + (int.Parse(score) + 100));
    }
}
```

---

## 48. Ask: Enter steps → Output: Calories (steps × 0.04)

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Steps : ");
        string steps = Console.ReadLine();
        Console.WriteLine("Calories Burned = " + (int.Parse(steps) * 0.04));
    }
}
```

---

## 49. Ask: Enter movie minutes → Output: Hours

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Movie Minutes : ");
        string minutes = Console.ReadLine();
        Console.WriteLine("Hours = " + (int.Parse(minutes) / 60.0));
    }
}
```

---

## 50. Ask: Enter hours & minutes → Output: Total minutes

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Hours : ");
        string hours = Console.ReadLine();
        Console.Write("Enter Minutes : ");
        string minutes = Console.ReadLine();
        Console.WriteLine("Total Minutes = " + (int.Parse(hours) * 60 + int.Parse(minutes)));
    }
}
```

