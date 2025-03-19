using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28278스택2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            StringBuilder result = new StringBuilder();
            int order = int.Parse(Console.ReadLine());

            for(int i = 0;i<order;i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch(input[0])
                {
                    case "1":
                        if (input[1]!=null)
                        {
                            int X = int.Parse(input[1]);
                            stack.Push(X);
                        }
                        break;
                    case "2":
                        if (stack.Count == 0) result.AppendLine("-1");
                        else result.AppendLine(stack.Pop().ToString());
                        break;
                    case "3":
                        result.AppendLine(stack.Count.ToString());
                        break;
                    case "4":
                        if (stack.Count != 0) result.AppendLine("0");
                        else result.AppendLine("1");
                        break;
                    case "5":
                        if (stack.Count != 0) result.AppendLine(stack.Peek().ToString());
                        else result.AppendLine("-1");
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine(result);
        }
    }
}
