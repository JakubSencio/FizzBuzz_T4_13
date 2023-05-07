using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_T4_13
{
    class Interface
    {
        public string FizzBuzzGame(int numberInput)
        {
            if(numberInput % 3 == 0 && numberInput % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if(numberInput % 5 == 0)
            {
                return "Buzz";
            }
            else if (numberInput % 3 == 0)
            {
                return "Fizz";
            }
            return $"{numberInput} , graj dalej!";

        }
    }
}
