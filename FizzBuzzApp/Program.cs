using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClass;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0, end = 0;
            Console.WriteLine("FizzBuzz Step 1");
            Console.Write("Please enter the starting number: ");
            try
            {
                start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the ending number: ");
                end = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please try again");
            }
            FizzBuzz fb = new FizzBuzz();
            string str = fb.GetOutputString(start, end);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
