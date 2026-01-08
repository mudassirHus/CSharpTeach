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