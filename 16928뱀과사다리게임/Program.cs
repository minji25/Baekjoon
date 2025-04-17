using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16928뱀과사다리게임
{
    class Program
    {

        static int[] board;
        static bool[] visited;
        static void Main(string[] args)
        {
            board = new int[101];
            visited = new bool[101];

            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]); //사다리 개수
            int m = int.Parse(input[1]); //뱀의 수

            for(int i = 0;i<n;i++)
            {
                string[] inputLadder = Console.ReadLine().Split(' ');
                board[int.Parse(inputLadder[0])] = int.Parse(inputLadder[1]);
            }
            for (int j = 0; j < m; j++)
            {
                string[] inputLadder = Console.ReadLine().Split(' ');
                board[int.Parse(inputLadder[0])] = int.Parse(inputLadder[1]);
            }

            for(int k=0;k<101;k++)
            {
                if (board[k] == 0)
                    board[k] = k;
            }
            
        }

        static int BFS()
        {
            var q = new Queue<(int pos, int cnt)>();
            q.Enqueue((1, 0));
            visited[1] = true;
            while (q.Count > 0)
            {
                var (pos, cnt) = q.Dequeue();

                for (int i = 1; i <= 6; i++)  // 주사위 1~6
                {
                    int next = pos + i;
                    if (next > 100) continue;

                    int dest = board[next]; // 사다리 또는 뱀 체크

                    if (!visited[dest])
                    {
                        if (dest == 100)
                            return cnt + 1;

                        visited[dest] = true;
                        q.Enqueue((dest, cnt + 1));
                    }
                }
            }

            return -1;  // 도달 불가능할 경우
        }
    }
}
