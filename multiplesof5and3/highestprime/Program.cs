using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestprime
{
    class Program
    {
        static void Main(string[] args)
        {
            primeFactor();
        }

        static void primeFactor()
        {
            long que = 600851475143;            
            for (int i = 1; i <= que; i ++)
            {
                if(que % i == 0 && i % 2 != 0)
                {
                                     
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        
    }
}
