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
        }

        // 5-4용 메소드
        static bool IsPrime(int n = 2)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0) return false;
            return true;
        }

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

        static int GetGCD(int x, int y)
        {
            int[] prime = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            // x, y는 이미 임시 변수: 입력 매개변수를 call by value하기 때문에
            //int tmpX = x; // 임시 변수
            //int tmpY = y; // 임시 변수
            int gcd = 1;
            // 반복문: foreach 선택(배열의 원소를 반복하므로)
            foreach (int i in prime)
            {
                // 거듭제곱이 있을 수 있어서 반복문 필요
                while ((x % i == 0) && (y % i == 0)) // 공약수라면
                {
                    gcd *= i;
                    x /= i; // 몫 구하기: 최종적으로는 tmpX = 0이 나옴
                    y /= i;
                    if (x == 0 || y == 0) break;
                }
                if (x == 0 || y == 0) break;
            }
            return gcd;
        }

        // while 구문(반복문)을 사용해서 재귀 구조로 변경 가능
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

        // 재귀 구조: 종료 조건(반드시) -> while 구문의 조건식; 재귀 조건 -> while 구문 안의 코드 블록
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
    }
}
