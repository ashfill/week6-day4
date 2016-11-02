using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            fibonacci(0, 1, 1, n);
            Console.ReadLine();
            
        }
        static void fibonacci(int a, int b, int count, int n)
        {
            Console.WriteLine(a);
            if (count < n)
                fibonacci(b, a + b, count + 1, n);
        }
    }
   
}
