using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11650좌표_정렬하기
{
    class Program
    {
        struct map //map을 만들어 x좌표, y좌표 구조 만들기
        {
            public int x;
            public int y;

            public map(int x, int y) //생성자
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            List<map> compare = new List<map>();
            

            int n = int.Parse(sr.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                compare.Add(new map(a, b));
  
            }

            compare.Sort((a, b) =>
            {
                if (a.x == b.x) return a.y.CompareTo(b.y);  // x가 같으면 y 기준 정렬
                return a.x.CompareTo(b.x);  // x 기준 정렬
            });

            foreach (var output in compare)
            {
                sb.AppendLine($"{output.x} {output.y}");
            }
            
            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}
