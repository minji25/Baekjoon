using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2751수_정렬하기_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(sr.ReadLine());
            }

            Array.Sort(input);

            foreach (int output in input)
            {
                sb.AppendLine(output.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
