using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }

        static void Fibonacci()
        {
            List<int> fib = new List<int>();
            int ans = 0;
            int lim = 4000000;
            int a = 1;
            int b = 2;
        
            while (b < lim)
            {
                if (b % 2 == 0)
                {
                    ans += b;
                }

                int c = a + b;
                a = b;
                b = c;

               
            }

            Console.WriteLine(ans);

                

        

            Console.ReadKey();

        }


    }
}
