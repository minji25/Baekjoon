using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2438별_찍기___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            star(n);     
        }
        static void star(int n)
        {
            if (n == 0) return; //n이 0이 되면 재귀 종료
            star(n - 1); //n에 -1하면서 재귀. 재귀는 stack구조이기 때문에 마지막 호출된 함수가 먼저 실행된다.
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
