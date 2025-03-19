using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1991트리순회
{
    class Node //Node 클래스 > Main함수에서 배열로 만들 것이다.
    {
        public char a; //최상위 노드
        public Node b; //왼쪽 자식 노드
        public Node c; //오른쪽 자식 노드

        public Node(char data)
        {
            this.a = data; //최상위 노드
            this.b = null; //왼쪽 자식 노드
            this.c = null; //오른쪽 자식 노드
        }
    }

    class BinaryTree //순회 클래스
    {
        public static void PreOrder(Node node) // 전위 순회 : 최상위,왼,오
        {
            if (node != null)
            {
                Console.Write(node.a);//노드가 있으면 출력
                PreOrder(node.b); //왼쪽 자식이 있는지 재귀로 확인
                PreOrder(node.c); //오른쪽 자식이 있는지 재귀로 확인
            }
        }
        public static void InOrder(Node node) // 중위 순회 : 왼, 최상위, 오
        {
            if (node != null)
            {
                InOrder(node.b); //왼쪽 자식이 비어있는지?
                Console.Write(node.a); //노드가 있으면 출력
                InOrder(node.c); //오른쪽 자식이 있는지?
            }
        }
        public static void PostOrder(Node node) // 후위 순회 : 왼, 오, 최상위
        {
            if (node != null)
            {
                PostOrder(node.b); //왼쪽 자식이 비어있는지?
                PostOrder(node.c); //오른쪽 자식이 비어있는지?
                Console.Write(node.a); //노드가 있으면 출력
            }
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Node[] tree = new Node[N]; //클래스 노드 객체 생성 [입력받은 N개]
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine(); //알파벳 입력 받기
                char a = input[0]; //최상위 (띄어쓰기 때문에 짝수 배열만 사용)
                char b = input[2]; //왼쪽
                char c = input[4]; //오른쪽

                if (tree[a-'A'] == null) tree[a -'A'] = new Node(a); //tree 배열에서 최상위 데이터가 없다면? 새 데이터 생성

                if (b != '.') //두번째 데이터가 빈칸이 아니라면?
                {
                    if (tree[b - 'A'] == null) tree[b - 'A'] = new Node(b); // 왼쪽 자식 노드 생성

                    tree[a- 'A'].b= tree[b - 'A'];   // 부모 노드와 연결
                }

                if (c != '.') //세번째 데이터가 빈칸이 아니라면?
                {
                    if (tree[c - 'A'] == null) tree[c - 'A'] = new Node(c); // 오른쪽 자식 노드 생성

                    tree[a - 'A'].c = tree[c - 'A']; // 부모 노드와 연결
                }
            }
            BinaryTree.PreOrder(tree[0]); Console.WriteLine(); //순회 클래스의 전위 순회를 출력
            BinaryTree.InOrder(tree[0]); Console.WriteLine();//순회 클래스의 중위 순회를 출력
            BinaryTree.PostOrder(tree[0]); Console.WriteLine();//순회 클래스의 후위 순회를 출력
        }
    }
}
