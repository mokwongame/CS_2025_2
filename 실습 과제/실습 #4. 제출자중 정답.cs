using System;
using System.Collections.Generic;

namespace MyMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem5();
        }

        static void Problem5()
        {
            Console.WriteLine("[5-1]\n\n");
            int x = 12;
            int y = 24;
            int ans = GetGCD(x, y);
            Console.WriteLine($"최대 공약수 = {ans}");

            Console.WriteLine("\n[5-2]\n\n");
            ans = GetGCD2(x, y);
            Console.WriteLine($"최대 공약수 = {ans}");
            ans = GetGCD3(x, y);
            Console.WriteLine($"최대 공약수 = {ans}");

            Console.WriteLine("\n[5-3]\n\n");
            int result = default(int);
            char op = '-';
            Calculate(ref x, op, ref y, out result);
            Console.WriteLine($"연산 결과: {x} {op} {y} = {result}");
            Calculate2(ref x, op, ref y, out result);
            Console.WriteLine($"연산 결과: {x} {op} {y} = {result}");

            // 5-4: 사용자로부터 자연수 X를 입력받아 2..X까지 모든 소수를 출력
            Console.WriteLine("\n[5-4]\n");

            Console.Write("자연수 a를 입력하세요: ");
            if (int.TryParse(Console.ReadLine(), out int X) && X >= 2)
            {
                List<int> primes = new List<int>();
                for (int number = 2; number <= X; number++)
                    if (IsPrime(number)) primes.Add(number);
                Console.WriteLine($"{X}까지의 소수들:");
                PrintIntArray(primes.ToArray());
                bool primeResult = IsPrime(X);
                Console.WriteLine($"{X}는 소수인가? → {primeResult}");

            }
            else
            {
                Console.WriteLine("유효한 자연수를 입력하세요.");
            }


            Console.WriteLine("\n[5-5]\n\n");
            // Console.WriteLine("숫자 배열을 입력하세요 : "); 
            // string input = Console.ReadLine() ?? "0"; 
            // string[] arStr = input.Split(" "); 
            // PrintArray(arStr); 
            // int[] arInt = new int[arStr.Length]; 
            // for (int i = 0; i < arInt.Length; i++) 
            // arInt[i] = int.Parse(arStr[i]); 
            // Console.WriteLine(""); PrintArray(arInt); 
            // ans = FindMax(arInt); 
            // Console.WriteLine($"\n최대값 = {ans}");

            // 5-6: 두 배열을 공백으로 구분하여 입력받아 같은 위치의 합을 출력
            Console.WriteLine("\n[5-6]\n\n");
            int[] A = { 1, 2, 3, 4, 5, 6, 7 };
            int[] B = { 10, 20, 30, 40, 50 };

            int[] sum = SumArray(A, B);

            // 결과 출력
            Console.Write("sum = ");
            foreach (int s in sum)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();


            Console.WriteLine("\n[5-7]\n\n");
            int[] C = new int[] { 1, 2, 3, 4, 5 };
            int[] D = new int[] { 1, 10, 20 };
            int[] union = UnionArray(C, D);
            Console.WriteLine("\n합집합 = ");
            PrintIntArray(union);

            Console.WriteLine("\n[5-8]\n\n");
            // 두 문자열을 키보드로 입력받아 공통 문자 출력
            Console.Write("문자열 s1을 입력하세요: ");
            string s1 = Console.ReadLine() ?? "";
            Console.Write("문자열 s2를 입력하세요: ");
            string s2 = Console.ReadLine() ?? "";
            string common = CommonChar(s1, s2);
            Console.WriteLine($"문자열 s1 = {s1}");
            Console.WriteLine($"문자열 s2 = {s2}");
            Console.WriteLine($"공통 문자 = {common}");

            Console.WriteLine("\n[5-9]\n\n");
            int i = 15;
            ans = FactoRecursive(i);
            Console.WriteLine($"{i}! = {ans}");

            Console.WriteLine("\n[5-10]\n\n");
            // 자연수 N 입력받아 16진수로 출력
            Console.Write("자연수 N(10진수)을 입력하세요: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                string hex = GetHexaNum(n);
                Console.WriteLine($"{n}의 16진수 표현 = {hex}");
            }
            else
            {
                Console.WriteLine("유효한 자연수 N(>=0)을 입력하세요.");
            }
        }

        // [5-1] 
        static int GetGCD(int x, int y)
        {
            int[] prime = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            int gcd = 1;
            foreach (int i in prime)
            {
                while ((x % i == 0) && (y % i == 0))
                {
                    gcd *= i;
                    x /= i;
                    y /= i;
                    if (x == 0 || y == 0) break;
                }
                if (x == 0 || y == 0) break;
            }
            return gcd;
        }

        // [5-2] 
        static int GetGCD2(int x, int y)
        {
            while (y != 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }
            return x;
        }

        // [5-2]
        static int GetGCD3(int x, int y)
        {
            if (y == 0) return x;
            else
            {
                int r = x % y;
                x = y;
                y = r;
                return GetGCD3(x, y);
            }
        }

        // [5-3] 
        static void Calculate(ref int x, char op, ref int y, out int result)
        {
            if (op == '/' && y == 0) y = 1;
            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                default:
                    result = 0;
                    break;
            }
        }

        static void Calculate2(ref int x, char op, ref int y, out int result)
        {
            if (op == '/' && y == 0) y = 1;
            result = op switch
            {
                '+' => x + y,
                '-' => x - y,
                '*' => x * y,
                '/' => x / y,
                _ => 0
            };
        }

        // [5-4] 
        static bool IsPrime(int a = 2)
        {
            if (a < 2) return false;
            if (a % 2 == 0) return a == 2;
            for (int i = 3; i * i <= a; i += 2)
                if (a % i == 0)
                    return false;
            return true;
        }

        // [5-5]
        static int FindMax(params int[] A)
        {
            int max = int.MinValue;
            foreach (var x in A)
            {
                if (x > max) max = x;
            }
            return max;
        }

        // [5-6] 
        static int[] SumArray(int[] A, int[] B)
        {
            int length = Math.Min(A.Length, B.Length); // 길이 맞추기
            int[] sum = new int[length];

            for (int i = 0; i < length; i++)
            {
                sum[i] = A[i] + B[i]; // 각 인덱스 합 저장
            }

            return sum;
        }


        // [5-7] 
        static int[] UnionArray(int[] A, int[] B)
        {
            if (A == null) A = new int[0];
            if (B == null) B = new int[0];

            int size = A.Length + B.Length;
            int[] union = new int[size];
            int idx = 0;

            // A의 모든 원소 추가(중복 제외)
            for (int i = 0; i < A.Length; i++)
            {
                if (!ArrayContains(union, idx, A[i]))
                {
                    union[idx++] = A[i];
                }
            }

            // B의 모든 원소 추가(중복 제외)
            for (int i = 0; i < B.Length; i++)
            {
                if (!ArrayContains(union, idx, B[i]))
                {
                    union[idx++] = B[i];
                }
            }

            int[] result = new int[idx];
            Array.Copy(union, result, idx);
            return result;
        }

        // [5-8]
        static string CommonChar(string s1, string s2)
        {
            string result = "";
            foreach (char c in s1)
            {
                if (s2.Contains(c) && !result.Contains(c))
                    result += c;
            }
            return result;
        }

        // [5-9]
        static int FactoRecursive(int n)
        {
            if (n <= 1) return 1;
            else return n * FactoRecursive(n - 1);
        }

        // [5-10]
        static string GetHexaNum(int n)
        {
            return n.ToString("X");
        }

        // 출력 보조 메서드
        static void PrintIntArray(int[] ar)
        {
            Console.Write("[ ");
            foreach (int x in ar)
                Console.Write($"{x} ");
            Console.WriteLine("]");
        }

        static void PrintStringArray(string[] ar)
        {
            Console.Write("[ ");
            foreach (string x in ar)
                Console.Write($"{x} ");
            Console.WriteLine("]");
        }

        // 입력 보조 메서드
        static int[] ReadIntArrayFromConsole()
        {
            string line = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(line)) return new int[0];
            string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> list = new List<int>();
            foreach (var p in parts)
            {
                if (int.TryParse(p, out int temp))
                    list.Add(temp);
            }
            return list.ToArray();
        }


        static bool ArrayContains(int[] arr, int length, int value)
        {
            for (int i = 0; i < length; i++)
                if (arr[i] == value) return true;
            return false;
        }
    }
}
