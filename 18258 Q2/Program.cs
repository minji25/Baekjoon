using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _18258_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            StringBuilder result = new StringBuilder();
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int last = 0;
            int orderint = int.Parse(sr.ReadLine());

            for (int i = 0; i < orderint; i++)
            {
                string[] input = sr.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "push":
                        if (input.Length >= 2)
                        {
                            int X = int.Parse(input[1]);
                            q.Enqueue(X);
                            last = X;
                        }
                        break;
                    case "pop":
                        if (q.Count == 0) result.AppendLine("-1");
                        else result.AppendLine(q.Dequeue().ToString());
                        break;
                    case "size":
                        if (q.Count > 0) result.AppendLine(q.Count.ToString());
                        else result.AppendLine("0");
                        break;
                    case "empty":
                        if (q.Count == 0) result.AppendLine("1");
                        else result.AppendLine("0");
                        break;
                    case "front":
                        if (q.Count == 0) result.AppendLine("-1");
                        else result.AppendLine(q.Peek().ToString());
                        break;
                    case "back":
                        if (q.Count == 0) result.AppendLine("-1");
                        else result.AppendLine(last.ToString());
                        break;
                }
            }
            sw.Write(result);
            sr.Close();
            sw.Close();
        }
    }
}