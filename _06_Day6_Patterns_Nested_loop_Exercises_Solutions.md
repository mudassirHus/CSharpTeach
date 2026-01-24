# Standard Pattern Printing Exercises Solutions

---

# PART 1: Single Loop Patterns

---

## 1. Print numbers from 1 to 10.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.Write("*");
}

ouput:

*****
```

---

## 2. Print N stars in a single line (N = 7).

```sharp
Console.Write("Enter the number of stars to print: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("*");
}

output:

*******
```

---

## 3. Print 5 stars vertically.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("*");
}

output:

*
*
*
*
*
```

---

## 4. Print numbers from 1 to 5 in a single line.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.Write(i + " ");
}

output:

1 2 3 4 5
```
---

## 5. Print numbers from 5 to 1.

```sharp
for (int i = 5; i >= 1; i--)
{
    Console.Write(i + " ");
}

output:

5 4 3 2 1
```

---

## 6. Print alternating star and dash.

```sharp
for (int i = 1; i <= 7; i++)
{
    Console.Write(i % 2 == 1 ? "*" : "-");
}

output:

*-*-*-*
```

---

## 7. Print first 5 even numbers.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.Write(i * 2 + " ");
}

output:

2 4 6 8 10
```

---

## 8. Print star followed by number.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.Write("*" + i);
}

output:

*1 *2 *3 *4 *5
```

---

## 9. Print the word HELLO four times.

```sharp
for (int i = 1; i <= 4; i++)
{
    Console.Write("HELLO ");
}

output:

HELLO HELLO HELLO HELLO
```

---

## 10. Print stars separated by space.

```sharp
for (int i = 1; i <= 5; i++)
{
    Console.Write("* ");
}

output:

* * * * *
```

---

# PART 2: Nested Loop Patterns

---

## 11. Print a 5x5 square of stars.

```sharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

output:

*****
*****
*****
*****
*****
```

---

## 12. Print a rectangle (3 rows, 7 columns).

```sharp
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 7; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

output:

*******
*******
*******
```

---

## 13. Print a 3x3 square of 1.

```sharp
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write("1");
    }
    Console.WriteLine();
}

output:

111
111
111
```

---

## 14. Print numbers from 1 to 3 in each row.

```sharp
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

output:

123
123
123
```

---

## 15. Print row number repeatedly.

```sharp
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i); 
    }
    Console.WriteLine(); 
}

output:

1
22
333
4444
```

---

## 16. Print increasing star triangle.

```sharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

output:

*
**
***
****
*****
```

---

## 17. Print decreasing star triangle.

```sharp
for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

output:

*****
****
***
**
*
```

---

## 18. Print increasing number triangle.

```sharp
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

output:

1
12
123
1234
```

---

## 19. Print decreasing number triangle.

```sharp
for (int i = 4; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

output:

1234
123
12
1
```

---

## 20. Print star triangle with spaces.

```sharp
for(int i = 1; i <= 4; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write("* ");

    }
}

output:

*
* *
* * *
* * * *
```

---

## 21. Print triangle of odd numbers.

```sharp
int num = 1;
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(num + " ");
        num += 2;
    }
    Console.WriteLine();
}

output:

1
3 5
7 9 11
```

---

## 22. Print alphabet triangle.

```sharp
for (int i = 65; i <= 68; i++)
{
    for (int j = 65; j <= i; j++)
    {
        Console.Write((char)j + " ");
    }
    Console.WriteLine();
}

output:

A
AB
ABC
ABCD
```

---

## 23. Print left-aligned half pyramid.

```sharp
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

output:

*
**
***
****
```

---

## 24. Print centered star pyramid.

```sharp
int oddLines = 1;
for(int i = 1; i <= 4; i++)
{
    for (int j = 4; j >= i; j--)
    {
        Console.Write("  ");
    }
    for (int k = 1; k <= oddLines; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    oddLines += 2;
}

output:

   *
  ***
 *****
*******
```

---

## 25. Print inverted pyramid.

```sharp
int oddLines = 7;
for(int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("  ");
    }
    for (int k = 1; k <= oddLines; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    oddLines -= 2;
}

output:

*******
 *****
  ***
   *
```

---

## 26. Print number pyramid.

```sharp
for(int i = 1; i <= 3; i++)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write("  ");
    }
    for(int k = 1; k < i; k++)
    {
        Console.Write(k + " ");
    }
    for(int l = i; l >= 1; l--)
    {
        Console.Write(l + " ");
    }
    Console.WriteLine();
}

output:

   1
  121
 12321
```

---

## 27. Print alphabet pyramid.

```sharp
for(char i = 'A'; i <= 'C'; i++)
{
    for(char j = 'C'; j >= i; j--)
    {
        Console.Write("  ");
    }
    for(char k = 'A'; k < i; k++)
    {
        Console.Write(k + " ");
    }
    for(char l = i; l >= 'A'; l--)
    {
        Console.Write(l + " ");
    }
    Console.WriteLine();
}

output:

   A
  ABA
 ABCBA
```

---

## 28. Print pyramid of even numbers.

```sharp
int evenScale = 2;
for (int i = 1; i <= 3; i++)
{
    for (int j = 3; j >= i; j--)
    {
        Console.Write("  ");
    }
    for (int k = 2; k <= evenScale; k+=2)
    {
        Console.Write(k + " ");
    }
    Console.WriteLine();
    evenScale += 4;
}

output:

    2
  2 4 6
2 4 6 8 10
```

---

## 29. Print hollow pyramid.

```sharp
int oddLines = 1;
for(int i = 1; i <= 4; i++)
{
    for(int j = 4; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= oddLines; k++)
    {
        Console.Write((i == 4 || k == 1 || k == oddLines)
            ? "*" : " ");
    }
    Console.WriteLine();
    oddLines += 2;
}

output:

   *
  * *
 *   *
*******
```

---

## 30. Print pyramid using row number.

```sharp
int oddLines = 1;
for(int i = 1; i <= 3; i++)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write("  ");
    }
    for(int k = 1; k <= oddLines; k++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    oddLines += 2;
}

output:

  1
 222
33333
```

---

## 31. Print star diamond.

```sharp
int oddLinesUpper = 1;
for(int i = 1; i <= 3; i++)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= oddLinesUpper; k++)
    {
        Console.Write("*");
    }
    oddLinesUpper += 2;
    Console.WriteLine();
}
int oddLinesLower = 3;
for(int i = 1; i <= 2; i++)
{
    for(int j = 1; j <= i + 1; j++)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= oddLinesLower; k++)
    {
        Console.Write("*");
    }
    oddLinesLower -= 2;
    Console.WriteLine();
}

output:

   *
  ***
 *****
  ***
   *
```

---

## 32. Print hollow diamond.

```sharp
int oddLinesUpper = 1;
for (int i = 1; i <= 3; i++)
{
    for (int j = 3; j >= i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= oddLinesUpper; k++)
    {
        if (k == 1 || k == oddLinesUpper)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    oddLinesUpper += 2;
    Console.WriteLine();
}
int oddLinesLower = 3;
for (int i = 1; i <= 2; i++)
{
    for (int j = 1; j <= i + 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= oddLinesLower; k++)
    {
        if (k == 1 || k == oddLinesLower)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    oddLinesLower -= 2;
    Console.WriteLine();
}

output:

   *
  * *
 *   *
  * *
   *
```

---

## 33. Print X pattern.

```sharp
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {
        if (i == j || i == 5 - (j - 1))
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

output:

*   *
 * *
  *
 * *
*   *
```

---

## 34. Print plus (+) pattern.

```sharp
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {
        Console.Write((i == 3 || j == 3) ? "*" : " ");
    }
    Console.WriteLine();
}

output:

  *
  *
*****
  *
  *
```

---

## 35. Print checkerboard pattern.

```sharp
for(int i = 1; i <= 3; i++)
{
    for(int j = 1; j <= 6; j++)
    {
        Console.Write((i == 1 && j % 2 == 1 || i == 2 && j % 2 == 0 || i == 3 && j % 2 == 1)
            ? "*" : " ");
    }
    Console.WriteLine();
}

output:

* * *
 * * *
* * *
```

---

## 36. Print number diamond.

```sharp
for(int i = 1; i <= 3; i++)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = i; k > 1; k--)
    {
        Console.Write(k);
    }
    for(int l = 1; l <= i; l++)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}
for(int i = 2; i >= 1; i--)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = i; k >= 2; k--)
    {
        Console.Write(k);
    }
    for(int l = 1; l <= i; l++)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}

output:

  1
 212
32123
 212
  1
```

---

## 37. Print alphabet diamond.

```sharp
for (char i = 'A'; i <= 'C'; i++)
{
    for (char j = 'C'; j >= i; j--)
    {
        Console.Write(" ");
    }
    for (char k = i; k > 'A'; k--)
    {
        Console.Write(k);
    }
    for (char l = 'A'; l <= i; l++)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}
for (char i = 'B'; i >= 'A'; i--)
{
    for (char j = 'B'; j >= i - 1; j--)
    {
        Console.Write(" ");
    }
    for (char k = i; k >= 'B'; k--)
    {
        Console.Write(k);
    }
    for (char l = 'A'; l <= i; l++)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}

output:

  A
 BAB
CBABC
 BAB
  A
```

---

## 38. Print Floyd's triangle.

```sharp
int num = 1;
for(int i = 1; i <= 4; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write(num++ + " ");
    }
    Console.WriteLine();
}

output:

1
2 3
4 5 6
7 8 9 10
```

---

## 39. Print hollow square.

```sharp
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {
        Console.Write((i == 1 || i == 5 || j == 1 || j == 5) ? "*" : " ");
    }
    Console.WriteLine();
}

output:

*****
*   *
*   *
*   *
*****
```

---

## 40. Print hollow right triangle.

```sharp
int oddLines = 1;
for(int i = 1; i <= 4; i++)
{
    for(int j = 1; j <= oddLines; j++)
    {
        Console.Write((i == 4 || j == 1 || j == oddLines) ? "*" : " ");
    }
    Console.WriteLine();
    oddLines += 2;
}

output:

*
**
* *
****
```

---

## 41. Print hourglass pattern.

```sharp
int oddLinesUpper = 5;
for(int i = 1; i <= 3; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= oddLinesUpper; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    oddLinesUpper -= 2;
}
int oddLinesLower = 3;
for(int i = 1; i <= 2; i++)
{
    for(int j = 2; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= oddLinesLower; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    oddLinesLower += 2;
}

output:

*****
 ***
  *
 ***
*****
```

---

## 42. Print zig-zag pattern.

```sharp
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {
        Console.Write((i % 2 == 1 && (j == 1 || j == 5)) || (i % 2 == 0 && (j == 2 || j == 4)) && (i != 5 && j != 3) ? "*" : " ");
    }
    Console.WriteLine();
}

output:

*   *
 * *
*   *
 * *
*   *
```

---

## 43. Print centered number triangle.

```sharp
int num = 1;
for(int i = 1; i <= 4; i++)
{
    for(int j = 4; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= i; k++)
    {
        Console.Write(num++ + " ");
    }
    Console.WriteLine();
}

output:

   1
  2 3
 4 5 6
7 8 9 10
```

---

## 44. Print butterfly pattern.

```sharp
int n = 4;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    int spaces = 2 * (n - i);
    for (int j = 1; j <= spaces; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
for (int i = n - 1; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    int spaces = 2 * (n - i);
    for (int j = 1; j <= spaces; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

output:

*       *
**     **
***   ***
*********
***   ***
**     **
*       *
```

---

## 45. Print mirror right triangle.

```sharp
for(int i = 1; i <= 4; i++)
{
    for(int j = 4; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

output:

   *
  **
 ***
****
```

---

## 46. Print number diamond.

```sharp
int oddLinesUpper = 1;
int oddNumsUpper = 1;
for (int i = 1; i <= 3; i++)
{
    for(int j = 3; j >= i; j--)
    {
        Console.Write("  ");
    }
    for(int k = 1; k <= oddLinesUpper; k++)
    {
        Console.Write(oddNumsUpper++ + " ");
    }
    Console.WriteLine();
    oddLinesUpper += 2;
}
int oddLinesLower = 3;
int lowerNumbers = 1;
for(int i = 1; i <= 2; i++)
{
    for(int j = 1; j <= i + 1; j++)
    {
        Console.Write("  ");
    }
    for(int k = 1; k <= oddLinesLower; k++)
    {
        Console.Write(++lowerNumbers + " ");
    }
    Console.WriteLine();
    oddLinesLower -= 2;
    lowerNumbers = 0;
}

output:

  1
 234
56789
 234
  1
```

---

## 47. Print star diamond with spaces.

```sharp
for(int i = 1; i <= 4; i++)
{
    for(int j = 4; j >= i; j--)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 3; k >= i; k--)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}

output:

   *
  * *
 * * *
* * * *
 * * *
  * *
   *
```

---
