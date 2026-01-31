# Array Practice Exercises Problems Solutions

---

# Phase 1: Very Basic 1D Array

---

## 1. Read and print elements of an array.

```sharp
Console.WriteLine("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Elements of an Array : ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}

```

---

## 2. Print elements of an array in reverse order.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Elements of an Array in Reverse Order : ");
for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write($"{arr[i]} ");
}
```
---

## 3. Find the sum of all elements in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

Console.WriteLine($"Sum of all elements in an Array : {sum}");

```
---

## 4. Count number of elements in an array without using Length property.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int count = 0;
foreach (int elements in arr)
{
    count++;
}

Console.WriteLine($"Number of elements in an Array without using Length property : {count}");

```
---

## 5. Find the maximum element in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine($"Maximum element in an Array is : {max}");

```
---

## 6. Find the minimum element in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine($"Minimum element in an Array is : {min}");

```

---

## 7. Count the number of even elements in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int evenCount = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine($"Number of even numbers in an Array is : {evenCount}");

```

---

## 8. Replace all negative elements in an array with zero.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        arr[i] = 0;
    }
}

Console.WriteLine("Array after replacing all negative elements with zeroes : ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

```

---

# Phase 2: Logical 1D Array Problems

---

## 9. Search an element in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());

int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter the element to search in the Array : ");
int searchElement = int.Parse(Console.ReadLine());

bool found = false;
int j;
for (j = 0; j < arr.Length; j++)
{
    if (arr[j] == searchElement)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine($"Element {searchElement} is found at {j} index of Array");
}
else
{
    Console.WriteLine($"Element {searchElement} is not found in the Array.");
}

```

---

## 10. Count occurrences of a given element in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter the element to count its occurrences in the Array : ");
int searchElement = int.Parse(Console.ReadLine());

int count = 0;
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] == searchElement)
    {
        count++;
    }
}

Console.WriteLine($"Element {searchElement} occurs {count} times in the Array.");

```

---

## 11. Copy elements of one array into another array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());

int[] arr1 = new int[size];
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr1[i] = int.Parse(Console.ReadLine());
}

int[] arr2 = new int[size];
for (int j = 0; j < arr1.Length; j++)
{
    arr2[j] = arr1[j];
}

Console.WriteLine("Elements of the first Array are copied into the second Array.");
Console.WriteLine("Elements of the second Array are:");
for (int k = 0; k < arr2.Length; k++)
{
    Console.Write($"{arr2[k]} ");
}

```

---

## 12. Reverse an array in place without using another array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int start = 0;
int end = arr.Length - 1;
while (start < end)
{
    int temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;
    start++;
    end--;
}

Console.WriteLine("Array after reversing in place without using another array:");
for (int j = 0; j < arr.Length; j++)
{
    Console.Write($"{arr[j]} ");
}

```

---

## 13. Find the second largest element in an array.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int largest = int.MinValue;
int secondLargest = int.MinValue;

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > largest)
    {
        secondLargest = largest;
        largest = arr[j];
    }
    else if (arr[j] > secondLargest && arr[j] != largest)
    {
        secondLargest = arr[j];
    }
}

if (secondLargest == int.MinValue)
{
    Console.WriteLine("There is no second largest element in the array.");
}
else
{
    Console.WriteLine($"The second largest element in the array is: {secondLargest}");
}

```

---

## 14. Check whether an array is sorted in ascending order.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

bool isSorted = true;
for (int j = 0; j < arr.Length - 1; j++)
{
    if (arr[j] > arr[j + 1])
    {
        isSorted = false;
        break;
    }
}

if (isSorted)
{
    Console.WriteLine("The array is sorted in ascending order.");
}
else
{
    Console.WriteLine("The array is not sorted in ascending order.");
}

```

---

## 15. Left rotate an array by one position.

```sharp
Console.Write("Enter the size of an Array : ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int firstElement = arr[0];
for (int j = 0; j < arr.Length - 1; j++)
{
    arr[j] = arr[j + 1];
}
arr[arr.Length - 1] = firstElement;

Console.WriteLine("Array after shifting elements by one position to the left:");
for (int k = 0; k < arr.Length; k++)
{
    Console.Write(arr[k] + " ");
}

```

---