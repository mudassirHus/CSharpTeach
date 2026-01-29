using ManualStringProcessing;
using static Program;

public class Test
{
    public static int CountLines(string data)
    {
        int i = 0;
        int count = 0;
        while (i < data.Length)
        {
            if (data[i] == '\n') { count++; }
            i++;
        }
        return count;
    }
    public static string[] GetLines(string data, int totalLines)
    {
        int i = 0;
        int j = 0;
        string[] lines = new string[totalLines];
        while (i < data.Length)
        {
            if (data[i] == '\n') j++;
            if (j >= totalLines) break;
            lines[j] = lines[j] + data[i];
            i++;
        }
        return lines;
    }
    public static string TrimLeadingSpaces(string line)
    {
        string result = "";
        int i = 0;
        while (i < line.Length)
        {
            if(result.Length == 0 && (line[i] == ' ' || line[i] == '\n'))
            {
                i++;
                continue;
            }
            result = result + line[i];
            i++;
        }
        return result;
    }
    public static string TrimTrailingSpaces(string line)
    {
        string result = "";
        int i = line.Length - 1;
        while (i >= 0)
        {
            if (result.Length == 0 && (line[i] == ' ' || line[i] == '\n'))
            {
                i--;
                continue;
            }
            result = line[i] + result;
            i--;
        }
        return result;
    }

    public static MyKeyValue BreakKeyValuePair(string line)
    {
        string key = "";
        string value = "";
        bool isKey = true;
        int i = 0;
        while (i < line.Length)
        {
            if (line[i] == ':')
            {
                isKey = false;
                i++;
                continue;             
            }
            if(isKey) 
            {
                key = key + line[i];
            }
            else
            {
                value = value + line[i];
            }

            i++;
        }

        key = TrimLeadingSpaces(key);
        key = TrimTrailingSpaces(key);
        value = TrimLeadingSpaces(value);
        value = TrimTrailingSpaces(value);

        MyKeyValue kv = new MyKeyValue();
        kv.key = key;
        kv.value = value;

        return kv;
    }
    public static string MyToLower(string input)
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c + 32);
            }
            result = result + c;
        }
        return result;
    }
    public static string ReplaceSpacesWithUnderscore(string input)
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == ' ')
            {
                c = '_';
            }
            result = result + c;
        }
        return result;
    }
    public static string RemoveExtraSpaces(string input)
    {
        string result = "";
        bool lastCharWasSpace = false;
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == ' ')
            {
                if (!lastCharWasSpace)
                {
                    result = result + c;
                    lastCharWasSpace = true;
                }
            }
            else
            {
                result = result + c;
                lastCharWasSpace = false;
            }
        }
        return result;
    }
    public static bool isDuplicate(string[] keys, string keyToCheck)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (keys[i] == keyToCheck)
            {
                return true;
            }
        }
        return false;
    }
}