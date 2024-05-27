using System;

class Program
{
    static void Main()
    {
        string[][] testCases = {
            new string[] { "Hello", "2", "world", ":-)" },
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
        };

        foreach (var initialArray in testCases)
        {
            string[] resultArray = GetShortStrings(initialArray);

            string initialArrayFormatted = "[" + string.Join(", ", initialArray) + "]";
  
            string resultArrayFormatted = "[" + string.Join(", ", resultArray) + "]";

            Console.WriteLine($"{initialArrayFormatted} → {resultArrayFormatted}");
        }

        Console.WriteLine("Hello, I passed the test :)");
    }

    static string[] GetShortStrings(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];

        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}
