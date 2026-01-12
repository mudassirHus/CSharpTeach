# C# Looping Programs (for loop)

---

## 1. Print numbers from 1 to 10

```csharp
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
```

---

## 2. Print numbers from 10 to 1

```csharp
    for (int i = 10; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
```

---

## 3. Print even numbers between 1 and 20

```csharp
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
```

---

## 4. Print odd numbers between 1 and 20

```csharp
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 == 1)
        {
            Console.WriteLine(i);
        }
    }
```

---

## 5. Print first 10 natural numbers

```csharp
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
```

---

## 6. Print numbers divisible by 5 from 1 to 50

```csharp
    for (int i = 1; i <= 50; i++)
    {
        if (i % 5 == 0)
        {
            Console.WriteLine(i);
        }
    }
```

---

## 7. Print numbers divisible by both 3 and 5 from 1 to 100

```csharp
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine(i);
        }
    }
```

---

## 8. Count even numbers from 1 to 100

```csharp
    int count = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }

    Console.WriteLine("Total even numbers from 1 to 100: " + count);
```

---

## 9. Count odd numbers from 1 to 100

```csharp
    int count = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 1)
        {
            count++;
        }
    }

    Console.WriteLine("Total odd numbers from 1 to 100: " + count);
```

---

## 10. Print numbers from 1 to 50 except multiples of 7

```csharp
    for (int i = 1; i <= 50; i++)
    {
        if (i % 7 != 0)
        {
            Console.WriteLine(i);
        }
    }
```

---

## 11. Multiplication table of a given number

```csharp
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
```

---

## 12. Sum from 1 to N

```csharp
    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    Console.WriteLine("Sum = " + sum);
```

---

## 13. Count digits of a number

```csharp
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    int count = 0;

    for (int n = number; n > 0; n /= 10)
    {
        count++;
    }

    Console.WriteLine("Total digits = " + count);
```

---

## 14. Reverse a number

```csharp
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    int reverse = 0;

    for (int n = number; n > 0; n /= 10)
    {
        int digit = n % 10;
        reverse = (reverse * 10) + digit;
    }

    Console.WriteLine("Reverse = " + reverse);
```

---

## 15. Sum numbers until user enters 0

```csharp
    int sum = 0;

    for (;;)
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            break;
        }

        sum += number;
    }

    Console.WriteLine("Total Sum = " + sum);
```

---

## 16. Stop when a negative number is entered

```csharp
    for (;;)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            break;
        }

        Console.WriteLine("You entered: " + number);
    }

    Console.WriteLine("Negative number entered. Loop stopped.");
```

---

## 17. Find the largest number until 0 is entered

```csharp
    int largest = int.MinValue;

    for (;;)
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            break;
        }

        if (number > largest)
        {
            largest = number;
        }
    }

    Console.WriteLine("Largest number = " + largest);
```

---

## 18. Check palindrome number

```csharp
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    int reverse = 0;

    for (int n = number; n > 0; n /= 10)
    {
        reverse = (reverse * 10) + (n % 10);
    }

    if (number == reverse)
        Console.WriteLine("Palindrome");
    else
        Console.WriteLine("Not Palindrome");
```

---

## 19. Check prime number

```csharp
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    bool isPrime = true;

    if (number <= 1)
        isPrime = false;
    else
    {
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
```

---

## 20. Fibonacci series

```csharp
    Console.Write("Enter number of terms: ");
    int n = int.Parse(Console.ReadLine());

    int first = 0, second = 1;

    for (int i = 1; i <= n; i++)
    {
        Console.Write(first + " ");
        int next = first + second;
        first = second;
        second = next;
    }
```

