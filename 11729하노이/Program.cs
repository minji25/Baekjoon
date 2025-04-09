<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11729하노이
{
    class Program
    {
        static StreamWriter sw;
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int k = int.Parse(sr.ReadLine());
                int l = (int)Math.Pow(2, k) - 1;
                sw.WriteLine(l);
                hanoi(1, 2, 3, k);
            }

        }

        static void hanoi(int a, int b, int c, int n)
        {
            if (n == 1)
            {
                sw.WriteLine($"{a} {c}");
                return;
            }            
            hanoi(a, c, b, n - 1);
            sw.WriteLine($"{a} {c}");
            hanoi(b, a, c, n - 1);
        }
       
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11729하노이
{
    class Program
    {
        static StreamWriter sw;
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int k = int.Parse(sr.ReadLine());
                int l = (int)Math.Pow(2, k) - 1;
                sw.WriteLine(l);
                hanoi(1, 2, 3, k);
            }

        }

        static void hanoi(int a, int b, int c, int n)
        {
            if (n == 1)
            {
                sw.WriteLine($"{a} {c}");
                return;
            }            
            hanoi(a, c, b, n - 1);
            sw.WriteLine($"{a} {c}");
            hanoi(b, a, c, n - 1);
        }
       
    }
}
>>>>>>> 4b7fb61aefbb28b2ee674984450a86175c9f8335
