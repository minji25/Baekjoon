using System;
using System.IO;

namespace _4779칸토어_집합
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                while (!sr.EndOfStream) //입력이 빌 때까지 반복
                {
                    int n = int.Parse(sr.ReadLine()); //입력된 문자열을 int n으로 가져오기
                    char[] result = new char[(int)Math.Pow(3, n)]; // "-"문자가 채워질 배열생성
                    CantorSet(result, 0, result.Length, true); //출력 함수 돌리기 (인자 : 배열, 현재 위치, 배열 길이, bool 값)
                    sw.WriteLine(new string(result)); //배열 출력
                }
            }
        }

        //출력할 문자 생성 함수
        static void CantorSet(char[] arr, int start, int length, bool fill)
        {
            if (length == 1) //배열 길이가 1일때
            {
                arr[start] = fill ? '-' : ' '; //현재 위치 값이 참이면 '-', 거짓이면 ' '
                return; //탈출
            }

            int segment = length / 3; //배열 3등분 / 재귀를 거듭할 수록 점점 더 쪼개짐

            //재귀
            CantorSet(arr, start, segment, fill); //배열 1부터 '-' (배열길이가 1이 될 때까지 재귀)
            CantorSet(arr, start + segment, segment, false); //' ' : 비어야할 현재 위치 값을 false값을 통해 비운다.
            CantorSet(arr, start + 2 * segment, segment, fill); //'-' : 3등분 중 3번째부터는 다시 true값 ('-')
        }
    }
}