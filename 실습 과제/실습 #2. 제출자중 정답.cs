using static System.Net.Mime.MediaTypeNames;

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
            //Console.WriteLine("[3-1]\n");
            //Console.Write("영어 이름을 쓰세요: ");
            //string name = Console.ReadLine() ?? "";
            //bool result = name.Contains('a') && name.Contains('e');
            //Console.WriteLine($"a와 e 포함 결과: {result}");

            Console.WriteLine("[3-2]\n");
            Console.Write("3-2 자연수를 입력받아 곱하기 4한 결과를 출력하는 프로그램을 비트 쉬프트 연산자를 이용하여 작성하시오.\n");

            int inputNum3_2 = 0;
            int result3_2 = 0;

            Console.Write("자연수를 입력하세요: ");

            if (int.TryParse(Console.ReadLine(), out inputNum3_2) && inputNum3_2 > 0) // 자연수인지 확인
            {
                result3_2 = inputNum3_2 << 2;

                Console.WriteLine($"입력받은 수 ({inputNum3_2})에 곱하기 4를 한 결과는: {result3_2} 입니다.");
            }
            else
            {
                Console.WriteLine("유효한 숫자 (자연수)를 입력해야 합니다.");
            }


            //Console.WriteLine("\n[3-3]\n");
            //Console.Write("자연수를 입력하세요: ");
            //string name = Console.ReadLine() ?? "0";
            //uint num = uint.Parse(name);
            ////uint result = num / 8;
            //uint result = num >> 3;
            //Console.WriteLine($"8로 나눈 결과: {result}");
            ////string strBin = result.ToString(); // 십진수로 문자열 생성
            //string strBin = result.ToString("B3"); // 이진수(B)로 문자열 3자리 생성
            //Console.WriteLine($"8로 나눈 이진수 결과: {strBin}");

            Console.WriteLine("\n[3-4]\n");
            Console.Write("3-4 자연수를 입력받아 짝수면 True를 출력하고 홀수면 False를 출력하는 프로그램을 작성하시오.\n");

            Console.Write("자연수를 입력하세요: ");
            int inputNum3_4 = 0;
            if (int.TryParse(Console.ReadLine(), out inputNum3_4) && inputNum3_4 > 0) // 자연수인지 확인
            {
                if (inputNum3_4 % 2 == 0)
                {
                    Console.WriteLine($"입력한 수 ({inputNum3_4})는 짝수 TRUE 입니다.");
                }
                else
                {
                    Console.WriteLine($"입력한 수 ({inputNum3_4})는 홀수 FALSE 입니다.");
                }
            }
            else
            {
                Console.WriteLine("유효한 숫자 (자연수)를 입력해야 합니다.");
            }


            //Console.WriteLine("\n[3-5]\n");
            //Console.Write("각도를 입력하세요: ");
            //string input = Console.ReadLine() ?? "0";
            //double angle = double.Parse(input);
            //string name = (angle > 90.0 && angle < 180.0) ? "둔각" : "예각 또는 직각";
            //Console.WriteLine($"입력한 각도는 {name}입니다.");

            Console.WriteLine("\n[3-6]\n");
            Console.Write("3-6  7 이하의 자연수를 입력받아 세 자리의 이진수로 변환하는 프로그램을 작성하시오.\n");
            Console.Write("7이하의 자연수를 입력하세요: ");
            int inputNum3_6 = 0;

            if (int.TryParse(Console.ReadLine(), out inputNum3_6) && inputNum3_6 > 0) // 자연수인지 확인
            {
                if (inputNum3_6 <= 7)
                {
                    string binaryString = Convert.ToString(inputNum3_6, 2);
                    string binaryString000 = binaryString.PadLeft(3, '0');
                    Console.WriteLine($"입력한 수 ({inputNum3_6})의 2진수 표현: {binaryString000}");

                }
                else
                {
                    Console.WriteLine("7이하의 자연수를 입력하세요");
                }
            }
            else
            {
                Console.WriteLine("유효한 숫자 (자연수)를 입력해야 합니다.");
            }

            //Console.WriteLine("\n[3-7]\n");
            //int[] ar = new int[] { 30, 2, 19, 1 }; // 1차원 배열 정의
            //int tmp = ar[0];
            ////ar[0] = ar[3];
            //ar[0] = ar[^1];
            //ar[^1] = tmp;
            //Console.WriteLine($"[{ar[0]}, {ar[1]}, {ar[2]}, {ar[3]}]");

            Console.WriteLine("\n[3-8]\n");
            Console.WriteLine("3-8 10개 이상의 문자를 포함하는 문장을 입력받아, 맨 앞의 3문자와 맨 뒤의 3문자를 교환한 문장을 출력하는 프로그램을 작성하시오.\n");
            Console.Write("문자열을 입력하세요 (10자 이상): ");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text) || text.Length < 10)
            {
                Console.WriteLine("문자열의 길이가 10자 이상이어야 합니다.");
            }
            else
            {

                string firstThree = text[0..3];


                string lastThree = text[^3..];

                string middle = text[3..^3];
                string swappedText = lastThree + middle + firstThree;
                Console.WriteLine($"변경된 문자열: {swappedText}");
            }

            //Console.WriteLine("\n[3-9]\n");
            //Console.Write("자연수를 입력하세요: ");
            //string name = Console.ReadLine() ?? "0";
            //uint num = uint.Parse(name);
            //uint result1 = num & 0b1111; // 이진수 마스킹
            //uint result2 = num & 0xF; // 16진수 마스킹
            //Console.WriteLine($"이진수 마스킹 = {result1:X}, 16진수 마스킹 = {result2:X}"); // X는 16진수로 출력 의미
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
