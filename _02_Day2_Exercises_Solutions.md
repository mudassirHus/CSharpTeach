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