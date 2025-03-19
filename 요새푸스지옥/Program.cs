using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 요새푸스지옥
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] result = new int[n];

            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            int count = 0;
            int sj = 0;

            for (int j = 0; j < n; j++)
            {
                while (list.Count() > 0)
                {
                    count++;
                    sj++;

                    if (sj > list.Count())
                    {
                        sj = 0;
                    }

                    if (count == k)
                    {
                        result[j] = list[sj];
                        list.Remove(list[sj]);
                        count = 0;
                        break;
                    }
                }
            }

            foreach (var bn in result)
            {
                Console.WriteLine(bn);
            }


        }
    }
}
