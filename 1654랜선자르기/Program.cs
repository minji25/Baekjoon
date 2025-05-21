using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1654랜선자르기
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]); //k개의 랜선
            int n = int.Parse(input[1]); //n개의 랜선

            long[] cables = new long[k]; //k개의 랜선의 길이를 담을 배열

            for (int i = 0; i < k; i++)
            {
                cables[i] = long.Parse(Console.ReadLine()); //입력받은 길이를 배열에 하나씩 넣음
            }

            long start = 1; //최소길이
            long end = GetMax(cables);  // 제일 긴 랜선 길이
            long result = 0; //출력할 길이 담아야함

            while (start <= end) //제일 긴 랜선 길이가 최소단위보다 클 때 동안
            {
                long mid = (start + end) / 2; //미드값을 구해줌
                long count = 0;

                foreach (long cable in cables)
                {
                    count += cable / mid; //미드길이로 잘랐을 때 랜선의 개수 카운트에 추가
                }

                if (count >= n) //n개의 랜선보다 k개의 랜선이 더 많을 때
                {
                    result = mid; //가능한 길이 result에 담음
                    start = mid + 1; //더 긴 길이로 시도
                }
                else
                {
                    end = mid - 1; //end 줄임
                }
            }

            Console.WriteLine(result); //길이 출력
        }

        static long GetMax(long[] arr) //제일 긴 랜선의 길이를 구하는 메서드
        {
            long max = arr[0];
            foreach (long val in arr)
            {
                if (val > max)
                    max = val;
            }
            return max;
        }
    }
}
