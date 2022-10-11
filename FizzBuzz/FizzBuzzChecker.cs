using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzChecker
    {
        public string FizzBuzzCheck(int fizzBuzz)
        {

            if (fizzBuzz % 3 == 0 && fizzBuzz % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (fizzBuzz % 3 == 0)
            {
                return "Fizz";
            }
            else if (fizzBuzz % 5 == 0)
            {
                return "Buzz";
            }

            
            return "This number is not divisible by 3 or 5!";
            
            
        }
    }
}
