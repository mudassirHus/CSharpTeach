# C# Standard Number-Based Programs

---

## 1. Check Armstrong Number

```csharp
    int sum = 0;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int temp = num;
    while (temp != 0)
    {
        int r = temp % 10;
        sum += r * r * r;
        temp /= 10;
    }

    if (sum == num)
        Console.WriteLine(num + " is an Armstrong Number.");
    else
        Console.WriteLine(num + " is not an Armstrong Number.");
```

---

## 2. Check Palindrome Number

```csharp
    int rev = 0;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int temp = num;
    while (temp != 0)
    {
        int r = temp % 10;
        rev = rev * 10 + r;
        temp /= 10;
    }

    if (rev == num)
        Console.WriteLine(num + " is a Palindrome.");
    else
        Console.WriteLine(num + " is not a Palindrome.");
```

---

## 3. Reverse a Number

```csharp
    int rev = 0;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int temp = num;
    while (temp != 0)
    {
        rev = rev * 10 + (temp % 10);
        temp /= 10;
    }

    Console.WriteLine("Reverse = " + rev);
```

---

## 4. Sum of Digits

```csharp
    int sum = 0;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }

    Console.WriteLine("Sum of digits = " + sum);
```

---

## 5. Product of Digits

```csharp
    int product = 1;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    while (num != 0)
    {
        product *= num % 10;
        num /= 10;
    }

    Console.WriteLine("Product of digits = " + product);
```

---

## 6. Count Digits

```csharp
    int count = 0;
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    while (num != 0)
    {
        count++;
        num /= 10;
    }

    Console.WriteLine("Total digits = " + count);
```

---

## 7. Strong Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int temp = num, sum = 0;

    while (temp != 0)
    {
        int r = temp % 10;
        int fact = 1;

        for (int i = 1; i <= r; i++)
            fact *= i;

        sum += fact;
        temp /= 10;
    }

    Console.WriteLine(sum == num ? "Strong Number" : "Not a Strong Number");
```

---

## 8. Harshad Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0, temp = num;

    while (temp != 0)
    {
        sum += temp % 10;
        temp /= 10;
    }

    Console.WriteLine(num % sum == 0 ? "Harshad Number" : "Not a Harshad Number");
```

---

## 9. Spy Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0, product = 1;

    while (num != 0)
    {
        int r = num % 10;
        sum += r;
        product *= r;
        num /= 10;
    }

    Console.WriteLine(sum == product ? "Spy Number" : "Not a Spy Number");
```

---

## 10. Neon Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int square = num * num, sum = 0;

    while (square != 0)
    {
        sum += square % 10;
        square /= 10;
    }

    Console.WriteLine(sum == num ? "Neon Number" : "Not a Neon Number");
```

---

## 11. Perfect Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= num / 2; i++)
        if (num % i == 0)
            sum += i;

    Console.WriteLine(sum == num ? "Perfect Number" : "Not a Perfect Number");
```

---

## 12. Abundant Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= num / 2; i++)
        if (num % i == 0)
            sum += i;

    Console.WriteLine(sum > num ? "Abundant Number" : "Not an Abundant Number");
```

---

## 13. Deficient Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= num / 2; i++)
        if (num % i == 0)
            sum += i;

    Console.WriteLine(sum < num ? "Deficient Number" : "Not a Deficient Number");
```

---

## 14. Prime Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    bool isPrime = num > 1;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
```

---

## 15. Composite Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    bool isComposite = false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isComposite = true;
            break;
        }
    }

    Console.WriteLine(isComposite ? "Composite Number" : "Not a Composite Number");
```

---

## 16. Factors of a Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    for (int i = 1; i <= num; i++)
        if (num % i == 0)
            Console.WriteLine(i);
```

---

## 17. Count Factors

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = 1; i <= num; i++)
        if (num % i == 0)
            count++;

    Console.WriteLine("Total factors = " + count);
```

---

## 18. Fibonacci Series

```csharp
    Console.Write("Enter number of terms: ");
    int n = int.Parse(Console.ReadLine());
    int a = 0, b = 1;

    for (int i = 1; i <= n; i++)
    {
        Console.Write(a + " ");
        int c = a + b;
        a = b;
        b = c;
    }
```

---

## 19. Factorial of a Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    long fact = 1;

    for (int i = 1; i <= num; i++)
        fact *= i;

    Console.WriteLine("Factorial = " + fact);
```

---

## 20. Automorphic Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int square = num * num, temp = num;
    bool isAuto = true;

    while (temp > 0)
    {
        if (square % 10 != temp % 10)
        {
            isAuto = false;
            break;
        }
        square /= 10;
        temp /= 10;
    }

    Console.WriteLine(isAuto ? "Automorphic Number" : "Not an Automorphic Number");
```

---

## 21. Duck Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    bool isDuck = false;

    while (num > 0)
    {
        if (num % 10 == 0)
        {
            isDuck = true;
            break;
        }
        num /= 10;
    }

    Console.WriteLine(isDuck ? "Duck Number" : "Not a Duck Number");
```

---

## 22. Disarium Number

```csharp
    Console.Write("Enter a number: ");
    string num = Console.ReadLine();
    int sum = 0;

    for (int i = 0; i < num.Length; i++)
    {
        int digit = num[i] - '0';
        sum += (int)Math.Pow(digit, i + 1);
    }

    Console.WriteLine(sum == int.Parse(num) ? "Disarium Number" : "Not a Disarium Number");
```

---

## 23. Happy Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int n = num;

    while (n != 1 && n != 4)
    {
        int sum = 0;
        while (n > 0)
        {
            int d = n % 10;
            sum += d * d;
            n /= 10;
        }
        n = sum;
    }

    Console.WriteLine(n == 1 ? "Happy Number" : "Not a Happy Number");
```

---

## 24. Buzz Number

```csharp
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine(num % 7 == 0 || num % 10 == 7
        ? "Buzz Number"
        : "Not a Buzz Number");
```

