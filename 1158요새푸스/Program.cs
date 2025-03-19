using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1158요새푸스
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);


            List<int> list = new List<int>();
            List<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            

            int index = 0;
            

            while (list.Count > 0)
            {
                index = (index + k - 1) % list.Count;  // k번째 사람을 찾기 위해 인덱스 조정  //34번째 줄 풀이 : index에 k를 더하고(k번째 숫자가 되어야함.) 배열이기 때문에 1을 뺀다.
                result.Add(list[index]);            // 제거할 사람을 결과 리스트에 추가                          위 값을 list의 길이와 나눈뒤의 나머지 값으로 index를 조정하는데
                list.RemoveAt(index);               // 리스트에서 해당 인덱스 삭제                               나머지가 없으면 나머지는 (index+k-1)이 된다.
            }                                                                                                    //while문을 반복할 때 업데이트된 index가 또 다시 조정되고, 이 과정을 반복.

            Console.Write("<" + string.Join(", ", result) + ">");
        }
           
    }
}
