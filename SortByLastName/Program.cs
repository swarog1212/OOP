using System;
using System.Collections.Generic;

namespace SortByLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> LastNames = new List<string> { "Антонов", "Петров", "Иванов", "Сидоров", "Коваленко" };
            Sort sort = new Sort();
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnterEvent += sort.ShowSort;
            Exception[] exception = new Exception[5];
            exception[0] = new FormatException();
            exception[1] = new InvallidNumberException(); //Собственное исключение
            exception[2] = new ArgumentException();
            exception[3] = new ArgumentNullException();
            exception[4] = new ArgumentOutOfRangeException();
            try
            {
                numberReader.Read(LastNames);
            }
            catch (Exception ex)
            {
                foreach (var item in exception)
                {
                    if (ex.Data.Count == item.Data.Count)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }
            }
        }
    }
}
