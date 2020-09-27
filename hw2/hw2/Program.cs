using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static int func1(int arg)
        {
            return -2;
        }

        static int func2(int arg)
        {
            return arg * 4;
        }

        static int func3(int arg)
        {
            return arg * arg;
        }

        static int func4(int arg)
        {
            arg *= -1/2;
            return arg + 5;
        }

        static void Main(string[] args)
        {
            int arg = Convert.ToInt32(Console.ReadLine());
            int arg_R = Convert.ToInt32(Console.ReadLine());
            if (arg > -7 && arg < 13)
            {                
                if (arg >= -6 && arg <= -4)
                    Console.WriteLine(func1(arg));
                else if (arg > -4 && arg <= 0)
                    Console.WriteLine(func2(arg));
                else if (arg > 0 && arg <= 2)
                    Console.WriteLine(func3(arg));
                else if (arg > 2 && arg <= 12)
                    Console.WriteLine(func4(arg));
            }
        }
    }
}
