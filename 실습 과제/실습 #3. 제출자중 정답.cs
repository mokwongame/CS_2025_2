using System.Text;

namespace Example4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n4-2 문제");
            Example_4_2();

            Console.WriteLine("\n4-4 문제");
            Example_4_4();

            Console.WriteLine("\n4-6 문제");
            Example_4_6();

            Console.WriteLine("\n4-8 문제");
            Example_4_8();

            Console.WriteLine("\n4-10 문제");
            Example_4_10();
        }

        //Example_4_2: 약수, 개수, 합
        static void Example_4_2()
        {
            Console.Write("자연수 N 입력: ");
            if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
            {
                Console.WriteLine("자연수를 올바르게 입력하세요.");
                return;
            }

            var divisors = new List<int>();
            long sum = 0;
            int count = 0;

            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    divisors.Add(i);
                    sum += i;
                    count++;

                    int pair = N / i;
                    if (pair != i)
                    {
                        divisors.Add(pair);
                        sum += pair;
                        count++;
                    }
                }
            }
            divisors.Sort();

            Console.WriteLine($"약수: {string.Join(", ", divisors)}");
            Console.WriteLine($"약수의 개수: {count}");
            Console.WriteLine($"약수의 합: {sum}");
        }

        //Example_4_4: 소수 출력
        static void Example_4_4()
        {
            int[] arr = { 4, 3, 10, 13, 15 };
            var primes = new List<int>();
            foreach (int x in arr)
                if (IsPrime(x)) primes.Add(x);

            Console.WriteLine("배열: {4, 3, 10, 13, 15}");
            Console.WriteLine("소수: " + (primes.Count > 0 ? string.Join(", ", primes) : "없음"));
        }
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0) return false;
            return true;
        }

        //Example_4_6: 문자열 숫자 → 정수
        static void Example_4_6()
        {
            Console.Write("자연수를 문자열로 입력(예: 123): ");
            string s = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(s) || !AllDigits(s))
            {
                Console.WriteLine("숫자만으로 이루어진 문자열을 입력하세요.");
                return;
            }

            long value = 0;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                int digit = s[i] - '0';
                int power = len - 1 - i;
                value += digit * (long)Math.Pow(10, power);
            }

            Console.WriteLine($"변환 결과: {value}");
        }
        static bool AllDigits(string t)
        {
            foreach (char c in t)
                if (c < '0' || c > '9') return false;
            return true;
        }

        //Example_4_8: 구구단
        static void Example_4_8()
        {
            for (int row = 0; row <= 8; row++)
            {
                if (row == 0) continue; //continue 사용

                for (int dan = 2; dan < 10; dan++)
                {
                    if (dan == 9) break; //break 사용
                    Console.Write($"{dan}*{row}={dan * row}\t");
                }
                Console.WriteLine();
            }
        }

        //Example_4_10: 2진수 변환
        static void Example_4_10()
        {
            Console.Write("0 이상의 정수 입력: ");
            if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
            {
                Console.WriteLine("0 이상의 정수를 입력하세요.");
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("2진수: 0");
                return;
            }

            var sb = new StringBuilder();
            while (n > 0)
            {
                sb.Insert(0, (n % 2).ToString());
                n /= 2;
            }
            Console.WriteLine($"2진수: {sb}");
        }
    }
}
