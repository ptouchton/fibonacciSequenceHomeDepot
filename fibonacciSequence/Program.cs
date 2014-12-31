using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 0;
            var myClass = new Program();

            for (int i = 0; i < 15; i++)
            {
                input = myClass.CalcNum(i);
                Console.WriteLine("Value: " + input);
            }
           
        }

        private int CalcNum(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
