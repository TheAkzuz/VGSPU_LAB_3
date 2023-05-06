using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Write X");
            x = Console.ReadLine();
            if (x.Length > 2)
            {
                int max = 0;
                for (int i = 0; i < x.Length - 1; i++)
                {
                    int lo = int.Parse(Convert.ToString(x[i]));
                    int lol = int.Parse(Convert.ToString(x[i + 1]));
                    if (lo + lol > max)
                    {
                        max = lo + lol;
                    }
                }
                Console.WriteLine("Max =" + max);
            }
            else
            {
                Console.WriteLine("X<3                ");
            }


        }
    }
}
