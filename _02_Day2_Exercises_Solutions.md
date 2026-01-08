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