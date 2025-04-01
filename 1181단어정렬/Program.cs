using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1181단어정렬
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            Dictionary<string, int> compare = new Dictionary<string, int>();

            for (int i = 0;i<n;i++)
            {
                string a = sr.ReadLine();
                int b = a.Length;
                if (compare.ContainsKey(a)) continue;
                compare.Add(a, b);
            }
            var result = compare.OrderBy(c => c.Value).ThenBy(c => c.Key);

            foreach (var d in result)
            {
                sw.WriteLine(d.Key);
            }

            sr.Close();
            sw.Close();

        }
    }
}
