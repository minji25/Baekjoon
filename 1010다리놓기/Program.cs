using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1010다리놓기
{
    class Program
    {
        static StreamWriter sw;
        static int[,] dp = new int[31, 31]; //값을 저장할 배열

        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                
                int t = int.Parse(sr.ReadLine());
                
                for(int i = 0; i<t;i++)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    int n = int.Parse(input[0]);
                    int m = int.Parse(input[1]);

                    sw.WriteLine(save(m,n)); //m개의 다리에서 n개의 다리와 중복되지 않게 조합되는 경우의 수

                }
            }
        }

        static int save(int start, int end)
        {
            if (dp[start, end] > 0) return dp[start, end]; // 이미 계산된 값

            if (end == 0 || start == end) return 1;    // nC0 = nCn = 1

            return dp[start, end] = save(start - 1, end - 1) + save(start - 1, end); //mCn = (m-1)C(n-1)+(m-1)Cn : 식을 쪼개어 저장
        }
    }
}
