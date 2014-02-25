using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzClass
{
    public class FizzBuzz
    {
        public string GetOutput(int dividend)
        {
            if (this.Contains3(dividend))
                return "lucky";
            if (dividend % 15 == 0)
                return "fizzbuzz";
            if (dividend % 5 == 0)
                return "buzz";
            if (dividend % 3 == 0)
                return "fizz";
            return dividend.ToString();
        }

        public string GetOutputString(int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += GetOutput(i) + " ";
            }
            return output.Trim();
        }

        //Performing integer operation in this function
        //This is much better than string operations, in terms of performance
        //And native to almost every platform
        public bool Contains3(int number)
        {
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit == 3)
                    return true;
                number = (number - digit) / 10;
            }
            return false;
        }
    }
}
