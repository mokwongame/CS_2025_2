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
