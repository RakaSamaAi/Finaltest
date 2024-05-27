using System;

class Program
{
    static void Main()
    {
        // Примеры массивов строк
        string[][] testCases = {
            new string[] { "Hello", "2", "world", ":-)" },
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
        };

        foreach (var initialArray in testCases)
        {
            // Вызов метода для получения нового массива с элементами длиной <= 3 символа
            string[] resultArray = GetShortStrings(initialArray);

            // Форматирование исходного массива
            string initialArrayFormatted = "[" + string.Join(", ", initialArray) + "]";
            // Форматирование результирующего массива
            string resultArrayFormatted = "[" + string.Join(", ", resultArray) + "]";

            // Вывод результата в требуемом формате
            Console.WriteLine($"{initialArrayFormatted} → {resultArrayFormatted}");
        }

        // Вывод дополнительного сообщения
        Console.WriteLine("Hello, I passed the test :)");
    }

    static string[] GetShortStrings(string[] inputArray)
    {
        // Определение количества строк, длина которых <= 3
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] resultArray = new string[count];

        // Заполнение нового массива
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
