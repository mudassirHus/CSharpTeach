using ManualStringProcessing;

public class Program
{
    public class MyKeyValue
    {
        public string key;
        public string value;
    }
    public static void Main(string[] args)
    {
        var data = "    employee name :    JOHN   doe   \n" +
        "    EMPLOYEE id:    0045  \n" +
        "    Department  :      finance  \n" +
        "joining date  :12   -   03   -2021  \n" +
        "email :     John.Doe@Company.COM\n " +
        "phone number:     91 - 98765   43210 \n" +
        "remarks :      excellent   performer \n" +
        "remarks :needs    improvement\n" +
        "END  of      report\n";

        int countLines = Test.CountLines(data);
        // Console.WriteLine($"Total Lines: {countLines}");

        string[] lines = Test.GetLines(data, countLines);
        // Console.WriteLine(lines.Length);

        string[] trimmedLines = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string trimmedLeading = Test.TrimLeadingSpaces(lines[i]);
            string trimmedTrailing = Test.TrimTrailingSpaces(trimmedLeading);
            trimmedLines[i] = trimmedTrailing;
            // Console.WriteLine($"'{trimmedTrailing}'");
        }

        MyKeyValue[] keyValuePairs = new MyKeyValue[trimmedLines.Length];
        for (int i = 0; i < trimmedLines.Length; i++)
        {
            MyKeyValue keyValuePair = Test.BreakKeyValuePair(trimmedLines[i]);
            keyValuePairs[i] = keyValuePair;
        }

        for (int i = 0; i < trimmedLines.Length; i++)
        {
            MyKeyValue pair = keyValuePairs[i];
            pair.key = Test.MyToLower(pair.key);
            pair.value = Test.MyToLower(pair.value);

            pair.key = Test.RemoveExtraSpaces(pair.key);
            pair.value = Test.RemoveExtraSpaces(pair.value);

            pair.key = Test.ReplaceSpacesWithUnderscore(pair.key);
        }

        string[] printedKeys = new string[trimmedLines.Length];
        for (int i = 0; i < trimmedLines.Length; i++)
        {
            if (keyValuePairs[i].value == "") 
            {
                // to skip "END  of      report\n";
                continue;
            }
            if (Test.isDuplicate(printedKeys, keyValuePairs[i].key)) 
            {
                // To Skip "remarks :needs    improvement\n"
                continue;
            }
            // code if key is phone number format it
            // code if key is date
            Console.WriteLine($"{keyValuePairs[i].key,18} : {keyValuePairs[i].value}");
            printedKeys[i] = keyValuePairs[i].key;
        }
    }
}