using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByLastName
{
    class Sort
    {
        private void SortAscending(List<string> LastNames)
        {
            LastNames.Sort();
            foreach (var item in LastNames)
            {
                Console.WriteLine(item);
            }
        }
        private void SortDescending(List<string> LastNames)
        {
            LastNames.Sort();
            LastNames.Reverse();
            foreach (var item in LastNames)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowSort(List<string> LastNames, int number)
        {
            switch (number)
            {
                case 1: SortAscending(LastNames); break;
                case 2: SortDescending(LastNames); break;
            }
        }
    }
}
