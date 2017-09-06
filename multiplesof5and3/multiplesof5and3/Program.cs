using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplesof5and3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(F(5));
            //Console.WriteLine(F(3));
            //Console.WriteLine(F(5) + F(3));

            //Console.ReadKey();
            also();

        }

        static int F(int n)
        {
            List<int> G = new List<int>();
            int t = 0;
            int ans = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    ans += i;
                }

                if (i % 5 == 0)
                {
                    ans += i;
                }


                int g = n * (1 + i);


                if (g < 1000)
                {

                    G.Add(g);

                }


            }

            foreach (int h in G)
            {

                t = t + h;

            }

            return t;

        }

        static void also()
        {

            int ans = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    ans += i;
                }

                else if (i % 5 == 0)
                {
                    ans += i;
                }
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
