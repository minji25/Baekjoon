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

        // 문자열의 첫 글자를 가져오는 예시 메서드
        static void GetFirstChar()
        {
            string str = "Hello";
            
            // 1. 인덱스 사용
            char firstChar1 = str[0];
            Console.WriteLine("인덱스 사용: " + firstChar1);
            
            // 2. Substring 사용
            string firstChar2 = str.Substring(0, 1);
            Console.WriteLine("Substring 사용: " + firstChar2);
            
            // 3. LINQ First() 사용
            char firstChar3 = str.First();
            Console.WriteLine("LINQ First() 사용: " + firstChar3);
        }

        // 문자 정렬을 위한 예시 메서드들
        static void SortCharArray()
        {
            // 1. Array.Sort 사용
            char[] chars1 = {'b', 'a', 'c', 'd'};
            Array.Sort(chars1);
            Console.WriteLine("Array.Sort 결과: " + new string(chars1));

            // 2. List.Sort 사용
            List<char> charList = new List<char> {'b', 'a', 'c', 'd'};
            charList.Sort();
            Console.WriteLine("List.Sort 결과: " + new string(charList.ToArray()));

            // 3. LINQ OrderBy 사용
            char[] chars2 = {'b', 'a', 'c', 'd'};
            var sorted = chars2.OrderBy(c => c);
            Console.WriteLine("LINQ OrderBy 결과: " + new string(sorted.ToArray()));

            // 4. 문자열 정렬
            string str = "bca";
            char[] chars3 = str.ToCharArray();
            Array.Sort(chars3);
            string sortedStr = new string(chars3);
            Console.WriteLine("문자열 정렬 결과: " + sortedStr);
        }

        // OrderBy 사용 예시 메서드
        static void OrderByExamples()
        {
            // 1. 기본 정렬 (오름차순)
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            var sortedNumbers = numbers.OrderBy(n => n);
            Console.WriteLine("기본 정렬: " + string.Join(", ", sortedNumbers));

            // 2. 내림차순 정렬 (OrderByDescending)
            var descendingNumbers = numbers.OrderByDescending(n => n);
            Console.WriteLine("내림차순 정렬: " + string.Join(", ", descendingNumbers));

            // 3. 문자열 정렬
            string[] names = { "Kim", "Lee", "Park", "Choi" };
            var sortedNames = names.OrderBy(n => n);
            Console.WriteLine("문자열 정렬: " + string.Join(", ", sortedNames));

            // 4. 문자열 길이로 정렬
            var lengthSortedNames = names.OrderBy(n => n.Length);
            Console.WriteLine("문자열 길이로 정렬: " + string.Join(", ", lengthSortedNames));

            // 5. 복합 정렬 (여러 조건)
            var students = new[]
            {
                new { Name = "Kim", Age = 20, Score = 85 },
                new { Name = "Lee", Age = 19, Score = 90 },
                new { Name = "Park", Age = 20, Score = 80 }
            };

            var sortedStudents = students
                .OrderBy(s => s.Age)        // 먼저 나이로 정렬
                .ThenBy(s => s.Score);      // 나이가 같으면 점수로 정렬

            Console.WriteLine("\n복합 정렬 결과:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"이름: {student.Name}, 나이: {student.Age}, 점수: {student.Score}");
            }
        }

        static void Main(string[] args)
        {
            // 첫 글자 가져오기 예시 실행
            GetFirstChar();
            
            // 문자 정렬 예시 실행
            SortCharArray();
            
            // OrderBy 예시 실행
            OrderByExamples();
            
            // 기존 좌표 정렬 코드
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
