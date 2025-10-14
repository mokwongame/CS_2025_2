namespace MyOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Example3();
            Problem3();
        }

        static void Problem3()
        {
            Console.WriteLine("[3-1]\n");
            //Console.Write("영어 이름을 쓰세요: ");
            //string name = Console.ReadLine() ?? "";
            //bool result = name.Contains('a') && name.Contains('e');
            //Console.WriteLine($"a와 e 포함 결과: {result}");

            Console.WriteLine("\n[3-3]\n");
            //Console.Write("자연수를 입력하세요: ");
            //string name = Console.ReadLine() ?? "0";
            //uint num = uint.Parse(name);
            ////uint result = num / 8;
            //uint result = num >> 3;
            //Console.WriteLine($"8로 나눈 결과: {result}");
            ////string strBin = result.ToString(); // 십진수로 문자열 생성
            //string strBin = result.ToString("B3"); // 이진수(B)로 문자열 3자리 생성
            //Console.WriteLine($"8로 나눈 이진수 결과: {strBin}");

            Console.WriteLine("\n[3-5]\n");
            //Console.Write("각도를 입력하세요: ");
            //string input = Console.ReadLine() ?? "0";
            //double angle = double.Parse(input);
            //string name = (angle > 90.0 && angle < 180.0) ? "둔각" : "예각 또는 직각";
            //Console.WriteLine($"입력한 각도는 {name}입니다.");

            Console.WriteLine("\n[3-7]\n");
            int[] ar = new int[] { 30, 2, 19, 1 }; // 1차원 배열 정의
            int tmp = ar[0];
            //ar[0] = ar[3];
            ar[0] = ar[^1];
            ar[^1] = tmp;
            Console.WriteLine($"[{ar[0]}, {ar[1]}, {ar[2]}, {ar[3]}]");

            Console.WriteLine("\n[3-9]\n");
            Console.Write("자연수를 입력하세요: ");
            string name = Console.ReadLine() ?? "0";
            uint num = uint.Parse(name);
            uint result1 = num & 0b1111; // 이진수 마스킹
            uint result2 = num & 0xF; // 16진수 마스킹
            Console.WriteLine($"이진수 마스킹 = {result1:X}, 16진수 마스킹 = {result2:X}"); // X는 16진수로 출력 의미
        }

        static void Example3()
        {
            // is 연산자
            double val = 15.34;
            object obj = val;
            Console.WriteLine($"is 연산자: {val is object}");
            Console.WriteLine($"is 연산자: {obj is double}");
            Console.WriteLine($"is 연산자: {obj is int}");

            // as 연산자
            string? str = "Wonderful";
            int iVal = 20;
            object obj2 = str as object;
            Console.WriteLine($"\nas 연산자: {obj2 == null}");
            obj2 = iVal as object;
            Console.WriteLine($"as 연산자: {obj2 == null}");
            str = obj as string;
            Console.WriteLine($"as 연산자: {str == null}");

            // default 연산자
            Console.WriteLine($"\ndefault of int: {default(int)}");
            Console.WriteLine($"default of double: {default(double)}");
            Console.WriteLine($"default of bool: {default(bool)}");
        }
    }
}
