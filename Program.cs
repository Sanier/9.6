using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;


namespace _9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEneteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
                catch (PersonException)
                {
                    Console.WriteLine("Некорректный язык ввода");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Непредвиденная ошибака {0}", ex.Message);
                }
            }
            
        }

        static void ShowNumber(int number)
        {
            Console.WriteLine("Введите фамилии 5-ти человек");
            List<string> name = new List<string>();
            bool match;
            for (int i = 0; i < 5; i++)
            {
                name.Add(Console.ReadLine());
                if (match = Regex.IsMatch(name[i], "^[a-zA-Z0-9]*$")) throw new PersonException(name[i]);
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Сортировка от А до Я");
                        Console.WriteLine();

                        name.Sort();
                        foreach (string item in name)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Сортировка от Я до А");
                        Console.WriteLine();

                        name.Sort();
                        name.Reverse();
                        foreach (string item in name)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
            }
        }
    }
}
