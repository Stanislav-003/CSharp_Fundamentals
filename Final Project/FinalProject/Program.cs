using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/*  	Визначити абстрактний клас (або інтерфейс) «телефон» (назва, фірма, ціна). 
 *      Визначити 2 похідні від нього класи: «мобільний телефон» (колір, об’єм пам’яті ), 
 *      «радіотелефон» (радіус дії, наявність автовідповідача ). У двох текстових файлах задано 
 *      дані про телефони двох різних фірм. Зчитати ці дані в один масив і вивести у текстовий файл: 
 *      1) всі телефони, посортовані за ціною із зазначенням загальної суми; 
 *      2) радіотелефони з автовідповідачем;
 */

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string appleFile = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\FinalProject\Apple.txt";
                string panasonicFile = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\FinalProject\Panasonic.txt";
                string allPhones = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\FinalProject\AllPhones.txt";

                List<IPhone> phones = new List<IPhone> { };

                try
                {
                    string[] appleLines = File.ReadAllLines(appleFile);

                    for (int i = 0; i < appleLines.Length; i += 6)
                    {
                        Match nameMatch = Regex.Match(appleLines[i], @"Назва\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        string name = nameMatch.Success ? nameMatch.Groups[1].Value : "";

                        Match companyMatch = Regex.Match(appleLines[i + 1], @"Фірма\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        string company = companyMatch.Success ? companyMatch.Groups[1].Value : "";

                        Match priceMatch = Regex.Match(appleLines[i + 2], @"Ціна\s*-\s*(\d+) грн", RegexOptions.IgnoreCase);
                        int price = int.Parse(priceMatch.Success ? priceMatch.Groups[1].Value : "");

                        Match colorMatch = Regex.Match(appleLines[i + 3], @"Колір\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        string color = colorMatch.Success ? colorMatch.Groups[1].Value : "";

                        Match memorySizeMatch = Regex.Match(appleLines[i + 4], @"Об’єм пам’яті\s*-\s*(\d+) GB", RegexOptions.IgnoreCase);
                        int memorySize = int.Parse(memorySizeMatch.Success ? memorySizeMatch.Groups[1].Value : "");

                        phones.Add(new MobilePhone(name, company, price, color, memorySize));
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл Apple.txt не знайдено! - {ex.Message}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Помилка вводу-виводу при роботі з файлом Apple.txt - {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка формату при роботі з файлом Apple.txt - {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при роботі з файлом Apple.txt - {ex.Message}");
                }

                try
                {
                    string[] panasonicLines = File.ReadAllLines(panasonicFile);

                    for (int i = 0; i < panasonicLines.Length; i += 6)
                    {
                        Match nameMatch = Regex.Match(panasonicLines[i], @"Назва\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        string name = nameMatch.Success ? nameMatch.Groups[1].Value : null;

                        Match companyMatch = Regex.Match(panasonicLines[i + 1], @"Фірма\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        string company = companyMatch.Success ? companyMatch.Groups[1].Value : "";

                        Match priceMatch = Regex.Match(panasonicLines[i + 2], @"Ціна\s*-\s*(\d+) грн", RegexOptions.IgnoreCase);
                        int price = int.Parse(priceMatch.Success ? priceMatch.Groups[1].Value : "");

                        Match radiusActionMatch = Regex.Match(panasonicLines[i + 3], @"Радіус дії\s*-\s*(\d+) м", RegexOptions.IgnoreCase);
                        int radiusAction = int.Parse(radiusActionMatch.Success ? radiusActionMatch.Groups[1].Value : "");

                        Match answeringMachineMatch = Regex.Match(panasonicLines[i + 4], @"Наявність автовідповідача\s*-\s*(.+)", RegexOptions.IgnoreCase);
                        bool answeringMachine = bool.Parse(answeringMachineMatch.Success ? answeringMachineMatch.Groups[1].Value : "");

                        phones.Add(new RadioPhone(name, company, price, radiusAction, answeringMachine));
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл Panasonic.txt не знайдено! - {ex.Message}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Помилка вводу-виводу при роботі з файлом Panasonic.txt - {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка формату при роботі з файлом Panasonic.txt - {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при роботі з файлом Panasonic.txt - {ex.Message}");
                }

                phones = (from phone in phones
                          orderby phone.Price descending
                          select phone).ToList();

                try
                {
                    using (StreamWriter sw = new StreamWriter(allPhones))
                    {
                        decimal totalSum = 0;
                        sw.WriteLine("1) Всі телефони, посортовані за ціною із зазначенням загальної суми:");
                        foreach (IPhone phone in phones)
                        {
                            if (phone is MobilePhone mobilePhone)
                            {
                                sw.WriteLine($"Назва: {phone.Name}, Фірма: {phone.Company}, Ціна: {phone.Price} грн, Колір: {mobilePhone.Color}, Об’єм пам’яті: {mobilePhone.MemorySize}GB");
                            }
                            else if (phone is RadioPhone radioPhone)
                            {
                                sw.WriteLine($"Назва: {phone.Name}, Фірма: {phone.Company}, Ціна: {phone.Price} грн, Радіус дії: {radioPhone.RadiusAction}м, Наявність автовідповідача: {radioPhone.AnsweringMachine}");
                            }
                            totalSum += phone.Price;
                        }
                        sw.WriteLine($"\n***Загальна сума: {totalSum} грн***");
                    }

                    using (StreamWriter sw = new StreamWriter(allPhones, true))
                    {
                        sw.WriteLine("\n2) Радіотелефони з автовідповідачем:");
                        foreach (IPhone phone in phones)
                        {
                            if (phone is RadioPhone radioPhone && radioPhone.AnsweringMachine == true)
                            {
                                sw.WriteLine($"Назва: {phone.Name}, Фірма: {phone.Company}, Ціна: {phone.Price} грн, Радіус дії: {radioPhone.RadiusAction}м, Наявність автовідповідача: {radioPhone.AnsweringMachine}");
                            }
                        }
                    }
                    Console.WriteLine("Дані успішно записані у файл AllPhones.txt");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл AllPhones.txt не знайдено! - {ex.Message}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Помилка вводу-виводу при роботі з файлом AllPhones.txt - {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка формату при роботі з файлом AllPhones.txt - {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при роботі з файлом AllPhones.txt - {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Загальна помилка у проекті: {ex.Message}");
            }
        }
    }
}
