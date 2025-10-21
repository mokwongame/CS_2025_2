namespace MyControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem4();
            //Example4();
            //Console.WriteLine("Hello, World!");
        }

        static void Problem4()
        {
            Console.WriteLine("[4-1]\n");
            //Console.Write("자연수를 입력하세요: ");
            //string input = Console.ReadLine() ?? "0";
            //uint N = uint.Parse(input);
            //uint ans = 1;
            //// 팩토리얼: 반복문
            //for (uint i = 2; i <= N; i++)
            //{
            //    ans *= i; // 예) 3! = 1*2*3
            //}
            //Console.WriteLine($"{N}! = {ans}");

            // [4-2]
            // 약수 구하기: N % i == 0이면 N의 약수는 i
            // i: 솟수 = {2, 3, 5, 7, 11, 13, ...}
            // 반복문 중에서 foreach가 유리: 배열의 원소를 반복하므로

            // [4-3]
            // X % i == 0 && Y % i == 0: i는 X, Y의 공약수
            Console.WriteLine("\n[4-3]\n");
            //Console.Write("자연수 X를 입력하세요: ");
            //string input = Console.ReadLine() ?? "0";
            //uint X = uint.Parse(input);
            //Console.Write("자연수 Y를 입력하세요: ");
            //input = Console.ReadLine() ?? "0";
            //uint Y = uint.Parse(input);
            //uint[] prime = new uint[] { 2, 3, 5, 7, 11, 13 };
            //uint tmpX = X; // 임시 변수
            //uint tmpY = Y; // 임시 변수
            //uint gcd = 1;
            //// 반복문: foreach 선택(배열의 원소를 반복하므로)
            //foreach (uint i in prime)
            //{
            //    // 거듭제곱이 있을 수 있어서 반복문 필요
            //    while ((tmpX % i == 0) && (tmpY % i == 0)) // 공약수라면
            //    {
            //        gcd *= i;
            //        tmpX /= i; // 몫 구하기: 최종적으로는 tmpX = 0이 나옴
            //        tmpY /= i;
            //        if (tmpX == 0 || tmpY == 0) break;
            //    }
            //    if (tmpX == 0 || tmpY == 0) break;
            //}
            //Console.WriteLine($"{X}와 {Y}의 최대 공약수 = {gcd}");

            // [4-4]
            // 솟수 배열 정의해서 해결
            // uint[] prime = new uint[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            Console.WriteLine("\n[4-5]\n");
            //Console.Write("문자열을 입력하세요: ");
            //string input = Console.ReadLine() ?? "";
            //string output = "";
            //// 반복문: 문자열의 문자 단위로 반복 -> foreach가 적절
            //const string vowel = "aeiou"; // 바뀌지 않아서 상수 문자열로 정의
            //foreach (char c in input)
            //{
            //    // 모음인지 판단 -> 조건문
            //    if (!vowel.Contains(c)) // 모음이 아니면
            //        output += c;
            //}
            //Console.WriteLine($"모음 없는 문자열 = {output}");

            //Console.WriteLine("\n[4-7]\n");
            //Console.Write("문자열을 입력하세요: ");
            //string input = Console.ReadLine() ?? "";
            //string output = "";
            //foreach (char c in input)
            //{
            //    if (char.IsLower(c)) output += char.ToUpper(c);
            //    else if (char.IsUpper(c)) output += char.ToLower(c);
            //    else output += c;
            //}
            //Console.WriteLine($"대소문자가 바뀐 문자열: {output}");

            Console.WriteLine("\n[4-9]\n");
            int[] arr = new int[] { 26, 74, 93, 10, 34, 65 };
            int imax = int.MinValue;
            int imin = int.MaxValue;
            // 원소 단위로 반복
            //foreach (int i in arr)
            //{
            //    if (i > imax) imax = i;
            //    if (i < imin) imin = i;
            //}
            int maxIdx = -1;
            int minIdx = -1;
            // index k를 기준으로 반복
            for (int k = 0; k < arr.Length; k++)
            {
                int i = arr[k];
                if (i > imax)
                {
                    imax = i;
                    maxIdx = k;
                }
                if (i < imin)
                {
                    imin = i;
                    minIdx = k;
                }
            }
            Console.WriteLine($"최대값 = {imax}, 최소값 = {imin}");
            // 최대, 최소 위치 바꾸기
            int tmp = arr[maxIdx];
            arr[maxIdx] = arr[minIdx];
            arr[minIdx] = tmp;
            Console.Write("[ ");
            foreach (int i in arr)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(" ]");
        }

        static void Example4()
        {
            int dir = 4;
            string sDir = dir switch
            {
                1 => "East",
                2 => "West",
                3 => "South",
                4 => "North",
                _ => "No direction"
            };
            Console.WriteLine($"{dir} = {sDir}");
        }
    }
}
