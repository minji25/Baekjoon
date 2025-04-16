using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2839설탕배달
{
    class Program
    {
        static StreamWriter sw;
        static int count=0;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int n = int.Parse(sr.ReadLine());

                while(n>=0)
                {
                  
                    if (n % 5 == 0)
                    {
                        sw.WriteLine((n / 5) + count);
                        return;
                    }

                    n -= 3;
                    count++;
                }

                sw.WriteLine(-1);
            }
        }

    }
}
