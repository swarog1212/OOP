using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByLastName
{
    class NumberReader
    {
        public delegate void NumberEnterDelegate(List<string> LastNames, int number);
        public event NumberEnterDelegate NumberEnterEvent;
        public void Read(List<string> LastNames)
        {
            Console.WriteLine("Для сортировки АЯ введите 1");
            Console.WriteLine("Для сортировки ЯА ввелите 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new InvallidNumberException("Entered the wrong number!!");
            NumberEntered(LastNames, number);
        }
        protected virtual void NumberEntered(List<string> LastNames, int number)
        {
            NumberEnterEvent?.Invoke(LastNames, number);
        }
    }
}
