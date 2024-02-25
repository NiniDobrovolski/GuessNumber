using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class WrongInputException : ApplicationException
    {
        private string _msg;

        public WrongInputException()
        {
            _msg = "Input must be integer number. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
