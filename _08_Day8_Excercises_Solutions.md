# Strings Exercises Problems Solutions

---

# Phase 1: Very Basic String Handling

---

## 1. Print each character of a string on a new line.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

Console.WriteLine("Characters in the string:");
foreach (char c in input)
{
    Console.WriteLine(c);
}
```

---

## 2. Count the number of characters in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

int count = 0;
foreach (char c in input)
{
    count++;
}

Console.WriteLine($"Total number of characters: {count}");

```
---

## 3. Reverse a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string reversed = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}

Console.WriteLine($"Reversed string: {reversed}");

```

---

## 4. Count the number of vowels in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

int vowelCount = 0;
foreach (char c in input)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        vowelCount++;
}

Console.WriteLine($"Total number of vowels in the string: {vowelCount}");

```

---

## 5. Count numeric characters in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

int numericCount = 0;
foreach (char c in input)
{
    if (c >= '0' && c <= '9')
        numericCount++;
}

Console.WriteLine($"Total number of numeric characters in the string: {numericCount}");

```

---

## 6. Count the number of spaces in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

int spaceCount = 0;
foreach (char c in input)
{
    if (c == ' ')
        spaceCount++;
}

Console.WriteLine($"Total number of spaces in the string: {spaceCount}");

```

---

## 7. Convert lowercase letters to uppercase in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string result = "";
foreach (char c in input)
{
    if (c >= 'a' && c <= 'z')
    {
        // Convert lowercase to uppercase
        char upperC = (char)(c - 32);
        result += upperC;
    }
    else
    {
        result += c;
    }
}

Console.WriteLine("Converted string:");
Console.WriteLine(result);

```

---

## 8. Check whether a string is a palindrome.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string reversed = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}

if (input.Equals(reversed))
{
    Console.WriteLine($"The string {input} is a palindrome.");
}
else
{
    Console.WriteLine($"The string {input} is not a palindrome.");
}

```

---

## 9. Count occurrences of a character in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

Console.WriteLine("Enter a character to count its occurrences:");
char characterToCount = Console.ReadLine()[0];

int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == characterToCount)
    {
        count++;
    }
}

Console.WriteLine($"The character '{characterToCount}' occurs {count} times in the string.");

```

---

## 10. Replace a character in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

Console.WriteLine("Enter the character to be replaced:");
char charToReplace = Console.ReadLine()[0];

Console.WriteLine("Enter the character to replace with:");
char replacementChar = Console.ReadLine()[0];

string result = "";
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == charToReplace)
    {
        result += replacementChar;
    }
    else
    {
        result += input[i];
    }
}

Console.WriteLine("Modified string:");
Console.WriteLine(result);

```

---

## 11. Remove all spaces from a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string result = "";
for (int i = 0; i < input.Length; i++)
{
    if (input[i] != ' ')
    {
        result += input[i];
    }
}

Console.WriteLine("String after removing all spaces:");
Console.WriteLine(result);

```

---

## 12. Find the first occurrence of a character in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

Console.WriteLine("Enter the character to find:");
char charToFind = Console.ReadLine()[0];

int index = -1;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == charToFind)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine($"The first occurrence of character '{charToFind}' is at index: {index}");
}
else
{
    Console.WriteLine($"Character '{charToFind}' not found in the string.");
}

```

---

## 13. Find the last occurrence of a character in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

Console.WriteLine("Enter the character to find:");
char charToFind = Console.ReadLine()[0];

int index = -1;
for (int i = input.Length - 1; i >= 0; i--)
{
    if (input[i] == charToFind)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine($"The last occurrence of character '{charToFind}' is at index: {index}");
}
else
{
    Console.WriteLine($"Character '{charToFind}' not found in the string.");
}

```

---

## 14. Find frequency of each character in a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

bool[] visited = new bool[input.Length];

for (int i = 0; i < input.Length; i++)
{
    if (visited[i])
        continue;

    int count = 1;

    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j])
        {
            count++;
            visited[j] = true;
        }
    }

    Console.WriteLine($"'{input[i]}' : {count}");
}

```

---

## 15. Remove duplicate characters from a string.

```sharp
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string result = "";

for (int i = 0; i < input.Length; i++)
{
    bool isDuplicate = false;

    for (int j = 0; j < i; j++)
    {
        if (input[i] == input[j])
        {
            isDuplicate = true;
            break;
        }
    }

    if (!isDuplicate)
    {
        result += input[i];
    }
}

Console.WriteLine("After removing duplicates:");
Console.WriteLine(result);

```

---

## 16. Count number of words in a sentence.

```sharp
Console.WriteLine("Enter a sentence:");
string input = Console.ReadLine();

int count = 1;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == ' ')
        count++;
}

Console.WriteLine("Number of words: " + count);

```

---

## 17. Reverse each word in a sentence.

```sharp
Console.WriteLine("Enter a sentence:");
string input = Console.ReadLine();

string result = "";
string word = "";

for (int i = 0; i < input.Length; i++)
{
    if (input[i] != ' ')
    {
        word = input[i] + word;
    }
    else
    {
        result += word + " ";
        word = "";
    }
}

// add the last word
result += word;

Console.WriteLine("Output:");
Console.WriteLine(result);

```

---

## 18. Find the longest word in a sentence.

```sharp
Console.WriteLine("Enter a sentence:");
string input = Console.ReadLine();

string longestWord = "";
string currentWord = "";

for (int i = 0; i < input.Length; i++)
{
    if (input[i] != ' ')
    {
        currentWord += input[i];
    }
    else
    {
        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }
        currentWord = "";
    }
}

// check last word
if (currentWord.Length > longestWord.Length)
{
    longestWord = currentWord;
}

Console.WriteLine("Longest word: " + longestWord);
Console.WriteLine("Length: " + longestWord.Length);

```

---

## 19. Check whether two strings are anagrams.

```sharp
Console.WriteLine("Enter first string:");
string s1 = Console.ReadLine();

Console.WriteLine("Enter second string:");
string s2 = Console.ReadLine();

bool isAnagram = true;

// length check
if (s1.Length != s2.Length)
{
    isAnagram = false;
}
else
{
    char[] arr2 = new char[s2.Length];

    // copy s2 into array
    for (int i = 0; i < s2.Length; i++)
    {
        arr2[i] = s2[i];
    }

    // compare characters
    for (int i = 0; i < s1.Length; i++)
    {
        bool found = false;

        for (int j = 0; j < arr2.Length; j++)
        {
            if (s1[i] == arr2[j])
            {
                found = true;
                arr2[j] = '#'; // mark used
                break;
            }
        }

        if (!found)
        {
            isAnagram = false;
            break;
        }
    }
}

if (isAnagram)
    Console.WriteLine("Anagram");
else
    Console.WriteLine("Not Anagram");
```
---

## 20. Convert first letter of each word to uppercase.

```sharp
Console.WriteLine("Enter a string:"); 
string str = Console.ReadLine();

string result = "";

for (int i = 0; i < str.Length; i++)
{
    if (i == 0 || str[i - 1] == ' ')
    {
        result += (char)(str[i] - 32);
    }
    else
    {
        result += str[i];
    }
}

Console.WriteLine(result);
```

---

## 21. Perform basic string compression.

```sharp
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();

string result = "";
int count = 1;

for (int i = 0; i < str.Length; i++)
{
    if (i < str.Length - 1 && str[i] == str[i + 1])
    {
        count++;
    }
    else
    {
        result += str[i] + count.ToString();
        count = 1;
    }
}

Console.WriteLine(result);
```

---

## 22. Check whether a string is a valid variable name identifier.

```sharp
Console.WriteLine("Enter a variable name:");
string str = Console.ReadLine();

bool isValid = true;

if (str.Length == 0)
{
    isValid = false;
}
else
{
    // first character
    if (!((str[0] >= 'a' && str[0] <= 'z') ||
          (str[0] >= 'A' && str[0] <= 'Z') ||
           str[0] == '_'))
    {
        isValid = false;
    }

    // remaining characters
    for (int i = 1; i < str.Length && isValid; i++)
    {
        if (!((str[i] >= 'a' && str[i] <= 'z') ||
              (str[i] >= 'A' && str[i] <= 'Z') ||
              (str[i] >= '0' && str[i] <= '9') ||
               str[i] == '_'))
        {
            isValid = false;
        }
    }
}

if (isValid)
{
    Console.WriteLine("The string is a valid variable name identifier.");
}
else
{
    Console.WriteLine("The string is not a valid variable name identifier.");
}
```

---

## 23. Extract numbers from a mixed string.

```sharp
Console.WriteLine("Enter a mixed string:");
string str = Console.ReadLine();

string result = "";
for (int i = 0; i < str.Length; i++)
{
    if (str[i] >= '0' && str[i] <= '9')
    {
        result += str[i];
    }
}

Console.WriteLine("The numbers extracted from the mixed string are:");
Console.WriteLine(result);
```
---

---

## 24. Find the most frequent word in a paragraph.

```sharp
Console.WriteLine("Enter paragraph:");
string input = Console.ReadLine();

string[] words = new string[200];
int wordCount = 0;
string current = "";

// extract words manually
for (int i = 0; i < input.Length; i++)
{
    if (input[i] != ' ')
    {
        current += input[i];
    }
    else
    {
        if (current != "")
        {
            words[wordCount] = current;
            wordCount++;
            current = "";
        }
    }
}

// last word
if (current != "")
{
    words[wordCount] = current;
    wordCount++;
}

// find most frequent word
int max = 0;
string maxWord = "";

for (int i = 0; i < wordCount; i++)
{
    if (words[i] == "#")
        continue;

    int count = 1;

    for (int j = i + 1; j < wordCount; j++)
    {
        if (words[i] == words[j])
        {
            count++;
            words[j] = "#";
        }
    }

    if (count > max)
    {
        max = count;
        maxWord = words[i];
    }
}

Console.WriteLine("Most frequent word: " + maxWord);
Console.WriteLine("Frequency: " + max);
```

---

## 25. Validate an email address using basic rules.

```sharp
Console.WriteLine("Enter email:");
string email = Console.ReadLine();

bool hasAt = false;
bool hasDot = false;
bool valid = true;

int atIndex = -1;
int dotIndex = -1;

// check first character
if (email[0] == '@')
    valid = false;

// check last character
if (email[email.Length - 1] == '.')
    valid = false;

for (int i = 0; i < email.Length; i++)
{
    if (email[i] == '@')
    {
        if (hasAt == true) // more than one @
        {
            valid = false;
        }
        hasAt = true;
        atIndex = i;
    }

    if (email[i] == '.')
    {
        hasDot = true;
        dotIndex = i;
    }
}

// must contain @ and .
if (!hasAt || !hasDot)
    valid = false;

// @ must come before .
if (atIndex > dotIndex)
    valid = false;

if (valid)
    Console.WriteLine("Valid email");
else
    Console.WriteLine("Invalid email");
```

---