using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            string programCS = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork9\Program.cs.txt";

            List<string> fileString = new List<string> { }; 

            using (StreamReader sr = new StreamReader(programCS))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileString.Add(line);
                }
            }

            //1.Порахуйте та запишіть кількість символів у кожному рядку.
            var lineLength = fileString.Select(line => line.Length);
            int x = 1;
            foreach (var length in lineLength)
            {
                Console.WriteLine($"Рядок {x} : {length} символів");
                x++;
            }

            //2.1 Знайдіть найдовшу та найкоротшу лінію.
            var sortedLines = from line in fileString
                              orderby line.Length ascending // Сортування елементів від найменшого до найбілього
                              select line;

            var shortestLine = sortedLines.First();
            var longestLine = sortedLines.Last();

            var shortestLineIndex = fileString.IndexOf(shortestLine) + 1;
            var longestLineIndex = fileString.IndexOf(longestLine) + 1;

            Console.WriteLine($"Найменший рядок {shortestLineIndex}: {shortestLine.Length}");
            Console.WriteLine($"Найбільший рядок {longestLineIndex}: {longestLine.Length}");

            //2.2 Знайдіть найдовші та найкоротші лінії.
            var sortedLines = from line in fileString.Select((value, index) => new { Value = value, Index = index })
                              orderby line.Value.Length ascending
                              select new
                              {
                                  Index = line.Index + 1,
                                  Length = line.Value.Length
                              };

            Console.WriteLine("\nВідсортовані рядки: \n");
            foreach (var line in sortedLines.ToList())
            {
                Console.WriteLine($"Рядок {line.Index} : {line.Length} символів");
            }

            var shortestLines = sortedLines.First().Length;
            var LongestLines = sortedLines.Last().Length;

            var shortestStrings = from line in sortedLines
                                  where line.Length == shortestLines
                                  select $"Рядок {line.Index} : {line.Length} символів";

            var longestStrings = from line in sortedLines
                                 where line.Length == LongestLines
                                 select $"Рядок {line.Index} : {line.Length} символів";

            Console.WriteLine("\nНайменші рядки:");
            foreach (var shortString in shortestStrings.ToList())
            {
                Console.WriteLine(shortString);
            }

            Console.WriteLine("\nНайбільші рядки:");
            foreach (var longString in longestStrings.ToList())
            {
                Console.WriteLine(longString);
            }

            //3. Знайдіть і запишіть тільки ті рядки, які складаються зі слова «var».
            Regex regex = new Regex("var");

            Console.WriteLine("Рядки, які містять слово «var»: ");
            foreach (var line in fileString)
            {
                if (regex.IsMatch(line))
                {
                    Console.WriteLine($"Рядок {fileString.IndexOf(line)}: {line.Length} елементів.");
                }
            }
        }
    }
}
