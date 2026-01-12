# C# Looping Programs (do-while loop)

---

## 1. Print numbers from 1 to 10

```csharp
    int i = 1;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
```

---

## 2. Print numbers from 10 to 1

```csharp
    int i = 10;
    do
    {
        Console.WriteLine(i);
        i--;
    } while (i >= 1);
```

---

## 3. Print even numbers between 1 and 20

```csharp
    int i = 1;
    do
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
        i++;
    } while (i <= 20);
```

---

## 4. Print odd numbers between 1 and 20

```csharp
    int i = 1;
    do
    {
        if (i % 2 == 1)
            Console.WriteLine(i);
        i++;
    } while (i <= 20);
```

---

## 5. Print first 10 natural numbers

```csharp
    int i = 1;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
```

---

## 6. Print numbers divisible by 5 from 1 to 50

```csharp
    int i = 1;
    do
    {
        if (i % 5 == 0)
            Console.WriteLine(i);
        i++;
    } while (i <= 50);
```

---

## 7. Print numbers divisible by both 3 and 5 from 1 to 100

```csharp
    int i = 1;
    do
    {
        if (i % 3 == 0 && i % 5 == 0)
            Console.WriteLine(i);
        i++;
    } while (i <= 100);
```

---

## 8. Count even numbers from 1 to 100

```csharp
    int i = 1, count = 0;
    do
    {
        if (i % 2 == 0)
            count++;
        i++;
    } while (i <= 100);

    Console.WriteLine("Even Count = " + count);
```

---

## 9. Count odd numbers from 1 to 100

```csharp
    int i = 1, count = 0;
    do
    {
        if (i % 2 == 1)
            count++;
        i++;
    } while (i <= 100);

    Console.WriteLine("Odd Count = " + count);
```

---

## 10. Print numbers from 1 to 50 except multiples of 7

```csharp
    int i = 1;
    do
    {
        if (i % 7 != 0)
            Console.WriteLine(i);
        i++;
    } while (i <= 50);
```

---

## 11. Multiplication table of a number

```csharp
    int number = int.Parse(Console.ReadLine());
    int i = 1;

    do
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
        i++;
    } while (i <= 10);
```

---

## 12. Sum from 1 to N

```csharp
    int n = int.Parse(Console.ReadLine());
    int i = 1, sum = 0;

    do
    {
        sum += i;
        i++;
    } while (i <= n);

    Console.WriteLine("Sum = " + sum);
```

---

## 13. Count digits of a number

```csharp
    int number = int.Parse(Console.ReadLine());
    int count = 0;

    do
    {
        count++;
        number /= 10;
    } while (number > 0);

    Console.WriteLine("Digits = " + count);
```

---

## 14. Reverse a number

```csharp
    int number = int.Parse(Console.ReadLine());
    int reverse = 0;

    do
    {
        reverse = (reverse * 10) + (number % 10);
        number /= 10;
    } while (number > 0);

    Console.WriteLine("Reverse = " + reverse);
```

---

## 15. Sum numbers until user enters 0

```csharp
    int sum = 0;
    int number;

    do
    {
        number = int.Parse(Console.ReadLine());
        if (number != 0)
            sum += number;
    } while (number != 0);

    Console.WriteLine("Total Sum = " + sum);
```

---

## 16. Stop when a negative number is entered

```csharp
    int number;

    do
    {
        number = int.Parse(Console.ReadLine());
        if (number >= 0)
            Console.WriteLine("You entered: " + number);
    } while (number >= 0);

    Console.WriteLine("Loop stopped");
```

---

## 17. Find the largest number until 0 is entered

```csharp
    int largest = int.MinValue;
    int number;

    do
    {
        number = int.Parse(Console.ReadLine());
        if (number != 0 && number > largest)
            largest = number;
    } while (number != 0);

    Console.WriteLine("Largest = " + largest);
```

---

## 18. Check palindrome number

```csharp
    int number = int.Parse(Console.ReadLine());
    int original = number, reverse = 0;

    do
    {
        reverse = (reverse * 10) + (number % 10);
        number /= 10;
    } while (number > 0);

    Console.WriteLine(original == reverse ? "Palindrome" : "Not Palindrome");
```

---

## 19. Check prime number

```csharp
    int number = int.Parse(Console.ReadLine());
    int i = 2;
    bool isPrime = number > 1;

    do
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
        i++;
    } while (i * i <= number);

    Console.WriteLine(isPrime ? "Prime" : "Not Prime");
```

---

## 20. Fibonacci series

```csharp
    int n = int.Parse(Console.ReadLine());
    int first = 0, second = 1, i = 1;

    do
    {
        Console.Write(first + " ");
        int next = first + second;
        first = second;
        second = next;
        i++;
    } while (i <= n);
```

