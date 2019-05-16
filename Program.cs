using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintFuzzBuzzNumbers;
namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(args[0]);
            Class1 prntnum = new Class1();
            prntnum.RunMethod(num);
        }
    }
}
