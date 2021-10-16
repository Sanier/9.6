using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6
{
    class NumberReader
    {
        public delegate void NumberEneteredDelegate(int number);
        public event NumberEneteredDelegate NumberEneteredEvent;

        public void Read()
        {

            Console.WriteLine();
            Console.WriteLine("Введите значение 1 (А-Я) либо 2 (Я-А)");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEneteredEvent(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEneteredEvent?.Invoke(number);
        }
    }
}
