using System;
using System.IO;
using System.Collections.Generic;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //1
            string data = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\data.txt";
            string rez = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\rez.txt";
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(data, System.Text.Encoding.UTF8))
                {
                    line = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(rez, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //1.2
            string data = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\data.txt";
            string rez = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\rez.txt";
            string line;

            try
            {
                line = File.ReadAllText(data);
                File.WriteAllText(rez, line);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //2
            string directory = @"D:\\";
            string writePath = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\DirectoryC.txt";

            try
            {
                DirectoryInfo dr = new DirectoryInfo(directory);
                FileInfo[] fileArr = dr.GetFiles();

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine($"Файли {directory}: ");

                    foreach (FileInfo file in fileArr)
                    {
                        sw.WriteLine($"Назва {file.Name}, розмір {file.Length} байт");
                    }
                }

                DirectoryInfo[] directoryArr = dr.GetDirectories();

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine();
                    sw.WriteLine($"Підкаталоги {directory}: ");

                    foreach (DirectoryInfo dir in directoryArr)
                    {
                        sw.Write($"Назва {dir.Name}, ");

                        FileInfo[] fileLenght = dir.GetFiles();
                        long lenght = 0;

                        foreach (FileInfo file in fileLenght)
                        {
                            lenght = lenght + file.Length;
                        }

                        sw.WriteLine($"Розмір {lenght} байт");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //3
            string directory = @"D:\\";
            string text = "";

            try
            {
                DirectoryInfo dr = new DirectoryInfo(directory);
                FileInfo[] fileArr = dr.GetFiles("*.txt");

                foreach (FileInfo f in fileArr)
                {
                    Console.WriteLine($"Текст з файла {f.Name}");

                    try
                    {
                        using (StreamReader sr = new StreamReader(f.FullName))
                        {
                            while ((text = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(text);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Помилка у зчитуванні файла {f.Name}: {e.Message}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region HomeWork
            //1
            string phonesWName = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\phones.txt";
            string phones = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\Phone's.txt";
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            try
            {
                using (StreamReader sr = new StreamReader(phonesWName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] phoneNumbersArr = line.Split(" - ");
                        if (phoneNumbersArr.Length == 2)
                        {
                            string PhoneNumber = phoneNumbersArr[0];
                            string PersonName = phoneNumbersArr[1];
                            PhoneBook[PersonName] = PhoneNumber;
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(phones))
                {
                    foreach (var p in PhoneBook)
                    {
                        sw.WriteLine(p.Value);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл не знайдено!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //2
            try
            {
                bool found = false;
                do
                {
                    Console.Write("Введіть ім'я користувача: ");
                    string name = Console.ReadLine();

                    if (PhoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(PhoneBook[name].Substring(3)); //Вивід номеру телефона без його порядкового номера у блокноті: 1), 2), ..., 9).
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine("Користувача з таким ім'ям не знайдено. Спробуйте ще раз!\n");
                    }
                }
                while (!found);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //3
            string newPhones = @"C:\Users\Stanislav Severin\Desktop\C#Fundamentals\CSharp_Fundamentals\HomeWork7\New.txt";

            try
            {
                List<string> newNumbersList = new List<string>();

                using (StreamReader sr = new StreamReader(phones))
                {
                    string line;
                    byte i = 1;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string newNumbers = line;

                        if (line.Length == 14 && line[3] == '8')
                        {
                            newNumbers = $"{i}) +38{line.Substring(4, 10)}";
                            //newNumbers = $"{line.Substring(0, 2)} +3{line.Substring(3, 11)}";
                        }
                        i++;
                        newNumbersList.Add(newNumbers);
                    }
                    
                }
                using (StreamWriter sw = new StreamWriter(newPhones))
                {
                    foreach (var n in newNumbersList)
                    {
                        sw.WriteLine(n);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}

