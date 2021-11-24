using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByLastName
{
    class InvallidNumberException: Exception
    {
        public string _Message { get; set; }
        public InvallidNumberException() { }
        public InvallidNumberException (string message) : base(message)
        {
            _Message = message;
        }
    }
}
