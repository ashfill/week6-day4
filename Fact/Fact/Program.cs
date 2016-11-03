using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int n = num; n > 0; n--)
            {
                for (int j = n; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine("The factorial of {0} is {1} ",(n),Factorial(n));
            }
            Console.ReadLine();
        }
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n*Factorial(n - 1);
        }
    }
}
