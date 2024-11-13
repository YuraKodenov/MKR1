using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Абсолютний шлях до файлу INPUT.TXT
        string inputFilePath = @"INPUT.TXT";
        string outputFilePath = @"OUTPUT.TXT";

        try
        {
            // Перевірка, чи існує файл INPUT.TXT
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Файл INPUT.TXT не знайдено за вказаним шляхом: " + inputFilePath);
                return;
            }

            // Читання числа x з файлу INPUT.TXT
            long x = long.Parse(File.ReadAllText(inputFilePath).Trim());

            // Знаходження кількості дільників
            int count = CountDivisors(x);

            // Запис результату у файл OUTPUT.TXT
            File.WriteAllText(outputFilePath, count.ToString());
            Console.WriteLine("Результат записано у файл OUTPUT.TXT");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: " + ex.Message);
        }
    }

    public static int CountDivisors(long x)
    {
        int count = 0;
        for (long i = 1; i * i <= x; i++)
        {
            if (x % i == 0)
            {
                count++; // Дільник i
                if (i != x / i)
                {
                    count++; // Дільник x / i, якщо він відрізняється від i
                }
            }
        }
        return count;
    }
}
