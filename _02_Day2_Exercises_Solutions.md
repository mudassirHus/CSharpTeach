1. Ask: Enter your Name → Output: Hello, <name> 
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What is Your Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello," +  name);
    }
}
2. Ask: Enter your age → Output: You will be <age+1> next year
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What is your Age : ");
        string age = Console.ReadLine();
        Console.WriteLine("Next Year you will be : " + (int.Parse(age) + 1));
    }
}
3. Ask: Enter your city → Output: You live in
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your City : ");
        string city = Console.ReadLine();

        Console.WriteLine("You Live in " + city);
    }
}
4. Ask: Enter your favorite number → Output: Result = number × 2
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Favorite Number : ");
        string number = Console.ReadLine();

        Console.WriteLine("Result = " + int.Parse(number) * 2);
    }
}
5. Ask: Enter two numbers → Output: You entered X and Y
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
6. Ask: Enter two numbers → Output: Sum = X + Y
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
7. Ask: Enter two numbers → Output: Difference = X − Y
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
8. Ask: Enter two numbers → Output: Product = X × Y
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
9. Ask: Enter dividend & divisor → Output: Quotient
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
10. Ask: Enter two numbers → Output: Remainder
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
11. Ask: Enter a number → Output: Square
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Square = " + (int.Parse(number) * int.Parse(number)));
    }
}
12. Ask: Enter a number → Output: Cube
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Cube = " + (int.Parse(number) * int.Parse(number) * int.Parse(number)));
    }
}
13. Ask: Enter length & width → Output: Rectangle area
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
14. Ask: Enter base & height → Output: Triangle area
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
15. Ask: Enter radius → Output: Circle area (π = 3.14)
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Radius : ");
        string radius = Console.ReadLine();
        Console.WriteLine("Circle Area = " + (3.14 * int.Parse(radius) * int.Parse(radius)));
    }
}
16. Ask: Enter monthly salary → Output: Yearly salary
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Monthly Salary : ");
        string monthlySalary = Console.ReadLine();
        Console.WriteLine("Yearly Salary = " + (int.Parse(monthlySalary) * 12));
    }
}
17. Ask: Enter 5 subject marks → Output: Average
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
        double average = (int.Parse(mark1) + int.Parse(mark2) + int.Parse(mark3) + int.Parse(mark4) + int.Parse(mark5)) / 5.0;
        Console.WriteLine("Average = " + average);
    }
}
18. Ask: Enter kilometers → Output: Meters
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Kilometers : ");
        string kilometers = Console.ReadLine();
        Console.WriteLine("Meters = " + (int.Parse(kilometers) * 1000));
    }
}
19. Ask: Enter minutes → Output: Seconds
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Minutes : ");
        string minutes = Console.ReadLine();
        Console.WriteLine("Seconds = " + (int.Parse(minutes) * 60));
    }
}
20. Ask: Enter days → Output: Hours
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Days : ");
        string days = Console.ReadLine();
        Console.WriteLine("Hours = " + (int.Parse(days) * 24));
    }
}
21. Ask: Enter Celsius → Output: Fahrenheit
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
22. Ask: Enter Fahrenheit → Output: Celsius
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
23. Ask: Enter meters → Output: Centimeters
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Meters : ");
        string meters = Console.ReadLine();
        Console.WriteLine("Centimeters = " + (int.Parse(meters) * 100));
    }
}
24. Ask: Enter kilograms → Output: Grams
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Kilograms : ");
        string kilograms = Console.ReadLine();
        Console.WriteLine("Grams = " + (int.Parse(kilograms) * 1000));
    }
}
25. Ask: Enter rupees → Output: Paise
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Rupees : ");
        string rupees = Console.ReadLine();
        Console.WriteLine("Paise = " + (int.Parse(rupees) * 100));
    }
}
26. Ask: Enter hours & rate per hour → Output: Total pay
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
27. Ask: Enter length of side → Output: Area of square
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Amount : ");
        string amount = Console.ReadLine();

        Console.Write("Enter GST % : ");
        string gst = Console.ReadLine();

        double ParsedAmount = double.Parse(amount);
        double ParsedGst = double.Parse(gst);

        double amountWIthGST = ParsedAmount * (ParsedGst / 100.0);

        Console.WriteLine("GST amount : " + (amountWIthGST - ParsedGst));
    }
}
28. Ask: Enter principal, rate, time → Output: Simple interest
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Principal Amount : ");
        string principal = Console.ReadLine();
        Console.Write("Enter Rate of Interest : ");
        string rate = Console.ReadLine();
        Console.Write("Enter Time (in years) : ");
        string time = Console.ReadLine();
        double simpleInterest = (int.Parse(principal) * int.Parse(rate) * int.Parse(time)) / 100.0;
        Console.WriteLine("Simple Interest = " + simpleInterest);
    }
}
29. Ask: Enter monthly saving → Output: Yearly saving
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Monthly Saving : ");
        string monthlySaving = Console.ReadLine();
        Console.WriteLine("Yearly Saving = " + (int.Parse(monthlySaving) * 12));
    }
}
30. Ask: Enter loan & months → Output: EMI
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Loan Amount : ");
        string loan = Console.ReadLine();
        Console.Write("Enter Number of Months : ");
        string months = Console.ReadLine();
        double emi = int.Parse(loan) / int.Parse(months);
        Console.WriteLine("EMI = " + emi);
    }
}
31. Ask: Enter number → Output: Last digit
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Last Digit = " + (int.Parse(number) % 10));
    }
}
32. Ask: Enter two-digit number → Output: Sum of digits
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Two-Digit Number : ");
        string number = Console.ReadLine();
        int firstDigit = int.Parse(number) / 10;
        int secondDigit = int.Parse(number) % 10;
        Console.WriteLine("Sum of Digits = " + (firstDigit + secondDigit));
    }
}
33. Ask: Enter number → Output: Half
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        string number = Console.ReadLine();
        Console.WriteLine("Half = " + (int.Parse(number) / 2.0));
    }
}
34. Ask: Enter apples → Output: Apples per person (2 people)
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number of Apples : ");
        string apples = Console.ReadLine();
        Console.WriteLine("Apples per Person (2 people) = " + (int.Parse(apples) / 2.0));
    }
}
35. Ask: Enter seconds → Output: Minutes
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Seconds : ");
        string seconds = Console.ReadLine();
        Console.WriteLine("Minutes = " + (int.Parse(seconds) / 60.0));
    }
}
36. Ask: Enter square side → Output: Perimeter
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Side of Square : ");
        string side = Console.ReadLine();
        Console.WriteLine("Perimeter = " + (4 * int.Parse(side)));
    }
}
37. Ask: Enter length, width, height → Output: Volume
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
38. Ask: Enter diameter → Output: Radius
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Diameter : ");
        string diameter = Console.ReadLine();
        Console.WriteLine("Radius = " + (int.Parse(diameter) / 2.0));
    }
}
39. Ask: Enter speed & time → Output: Distance
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Speed (in km/h) : ");
        string speed = Console.ReadLine();
        Console.Write("Enter Time (in hours) : ");
        string time = Console.ReadLine();
        Console.WriteLine("Distance = " + (int.Parse(speed) * int.Parse(time)));
    }
}
40. Ask: Enter distance & time → Output: Speed
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Distance (in km) : ");
        string distance = Console.ReadLine();
        Console.Write("Enter Time (in hours) : ");
        string time = Console.ReadLine();
        Console.WriteLine("Speed = " + (int.Parse(distance) / int.Parse(time)));
    }
}
41. Ask: Enter first & last name → Output: Full name
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Name : ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name : ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Full Name = " + firstName + " " + lastName);
    }
}
42. Ask: Enter birth year → Output: Age (assume current year = 2025)
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Birth Year : ");
        string birthYear = Console.ReadLine();
        int age = 2025 - int.Parse(birthYear);
        Console.WriteLine("Age = " + age);
    }
}
43. Ask: Enter bill & people → Output: Cost per person
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Total Bill Amount : ");
        string bill = Console.ReadLine();
        Console.Write("Enter Number of People : ");
        string people = Console.ReadLine();
        double costPerPerson = int.Parse(bill) / int.Parse(people);
        Console.WriteLine("Cost per Person = " + costPerPerson);
    }
}
44. Ask: Enter marks & total → Output: Percentage
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks Obtained : ");
        string marks = Console.ReadLine();
        Console.Write("Enter Total Marks : ");
        string total = Console.ReadLine();
        double percentage = (int.Parse(marks) / (double)int.Parse(total)) * 100.0;
        Console.WriteLine("Percentage = " + percentage + "%");
    }
}