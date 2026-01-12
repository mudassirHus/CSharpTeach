# C# Looping Programs (while loop)

---

## 1. Print numbers from 1 to 10

```csharp
{
    int i = 1;
    while (i <= 10)
    {
        Console.WriteLine(i);
        i++;
    }
}
```

---

## 2. Print numbers from 10 to 1

```csharp
{
    int i = 10;
    while (i >= 1)
    {
        Console.WriteLine(i);
        i--;
    }
}
```

---

## 3. Print even numbers between 1 and 20

```csharp
{
    int i = 1;
    while (i <= 20)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
        i++;
    }
}
```

---

## 4. Print odd numbers between 1 and 20

```csharp
{
    int i = 1;
    while (i <= 20)
    {
        if (i % 2 == 1)
            Console.WriteLine(i);
        i++;
    }
}
```

---

## 5. Print first 10 natural numbers

```csharp
{
    int i = 1;
    while (i <= 10)
    {
        Console.WriteLine(i);
        i++;
    }
}
```

---

## 6. Print numbers divisible by 5 from 1 to 50

```csharp
{
    int i = 1;
    while (i <= 50)
    {
        if (i % 5 == 0)
            Console.WriteLine(i);
        i++;
    }
}
```

---

## 7. Print numbers divisible by both 3 and 5 from 1 to 100

```csharp
{
    int i = 1;
    while (i <= 100)
    {
        if (i % 3 == 0 && i % 5 == 0)
            Console.WriteLine(i);
        i++;
    }
}
```

---

## 8. Count even numbers from 1 to 100

```csharp
{
    int i = 1, count = 0;
    while (i <= 100)
    {
        if (i % 2 == 0)
            count++;
        i++;
    }
    Console.WriteLine("Even Count = " + count);
}
```

---

## 9. Count odd numbers from 1 to 100

```csharp
{
    int i = 1, count = 0;
    while (i <= 100)
    {
        if (i % 2 == 1)
            count++;
        i++;
    }
    Console.WriteLine("Odd Count = " + count);
}
```

---

## 10. Print numbers from 1 to 50 except multiples of 7

```csharp
{
    int i = 1;
    while (i <= 50)
    {
        if (i % 7 != 0)
            Console.WriteLine(i);
        i++;
    }
}
```

---

## 11. Multiplication table of a number

```csharp
{
    int number = int.Parse(Console.ReadLine());
    int i = 1;
    while (i <= 10)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
        i++;
    }
}
```

---

## 12. Sum from 1 to N

```csharp
{
    int n = int.Parse(Console.ReadLine());
    int i = 1, sum = 0;
    while (i <= n)
    {
        sum += i;
        i++;
    }
    Console.WriteLine("Sum = " + sum);
}
```

---

## 13. Count digits of a number

```csharp
{
    int number = int.Parse(Console.ReadLine());
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    Console.WriteLine("Digits = " + count);
}
```

---

## 14. Reverse a number

```csharp
{
    int number = int.Parse(Console.ReadLine());
    int reverse = 0;
    while (number > 0)
    {
        reverse = (reverse * 10) + (number % 10);
        number /= 10;
    }
    Console.WriteLine("Reverse = " + reverse);
}
```

---

## 15. Sum numbers until user enters 0

```csharp
{
    int sum = 0;
    while (true)
    {
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
            break;
        sum += number;
    }
    Console.WriteLine("Total Sum = " + sum);
}
```

---

## 16. Stop when a negative number is entered

```csharp
{
    while (true)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
            break;
        Console.WriteLine("You entered: " + number);
    }
    Console.WriteLine("Loop stopped");
}
```

---

## 17. Find the largest number until 0 is entered

```csharp
{
    int largest = int.MinValue;
    while (true)
    {
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
            break;
        if (number > largest)
            largest = number;
    }
    Console.WriteLine("Largest = " + largest);
}
```

---

## 18. Check palindrome number

```csharp
{
    int number = int.Parse(Console.ReadLine());
    int original = number, reverse = 0;

    while (number > 0)
    {
        reverse = (reverse * 10) + (number % 10);
        number /= 10;
    }

    Console.WriteLine(original == reverse ? "Palindrome" : "Not Palindrome");
}
```

---

## 19. Check prime number

```csharp
{
    int number = int.Parse(Console.ReadLine());
    int i = 2;
    bool isPrime = number > 1;

    while (i * i <= number)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
        i++;
    }

    Console.WriteLine(isPrime ? "Prime" : "Not Prime");
}
```

---

## 20. Fibonacci series

```csharp
{
    int n = int.Parse(Console.ReadLine());
    int first = 0, second = 1, i = 1;

    while (i <= n)
    {
        Console.Write(first + " ");
        int next = first + second;
        first = second;
        second = next;
        i++;
    }
}
```

