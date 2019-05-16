using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFuzzBuzzNumbers
{
    public class Class1
    {
        public void RunMethod(int q)
        {
            for (int i = 1; i <= q; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(" FUzz ");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(" Buzz ");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
