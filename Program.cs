using System;


namespace _9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 фамилий студентов");
            Student();

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEneteredEvent += ShowNumber;

            try
            {
                numberReader.Read();
            }
            catch(FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            catch()
            {

            }
        }

        static void ShowNumber(int number)
        {
            switch(number)
            {
                case 1:
                    {
                        Console.WriteLine("А-Я");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Я-А");

                        break;

                    }
            }
        }

        static void Student()
        {
            string[] name = new string[4];

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
        }


    }
}
