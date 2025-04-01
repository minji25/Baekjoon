using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _20499Darius
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split('/');
            int k = int.Parse(input[0]);
            int d = int.Parse(input[1]);
            int a = int.Parse(input[2]);

            if (k + a < d || d == 0) Console.WriteLine("hasu");
            else Console.WriteLine("gosu");

        }
    }
}
