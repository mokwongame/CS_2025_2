namespace MyData
{
    internal class Program
    {
        // Rainbow 정의
        enum Rainbow : short { Red, Orange = 3, Yellow, Green = 10, Blue = 12, Indigo, Violet = 20 };

        static void Main(string[] args)
        {
            Console.WriteLine("[2-2]\n");
            Console.WriteLine($"{Rainbow.Red} = {(int)Rainbow.Red}"); // Red부터 Violet까지 출력
            Console.WriteLine($"{Rainbow.Orange} = {(int)Rainbow.Orange}");
            Console.WriteLine($"{Rainbow.Yellow} = {(int)Rainbow.Yellow}");
            Console.WriteLine($"{Rainbow.Green} = {(int)Rainbow.Green}");
            Console.WriteLine($"{Rainbow.Blue} = {(int)Rainbow.Blue}");
            Console.WriteLine($"{Rainbow.Indigo} = {(int)Rainbow.Indigo}");
            Console.WriteLine($"{Rainbow.Violet} = {(int)Rainbow.Violet}");

            Console.WriteLine("\n[2-4]\n");
            string[][] strArr = new string[][] // 재기드 배열 선언
            {
                new string[] { "apple", "orange" },
                new string[] { "car", "train", "ship" },
                new string[] { "Tom", "Jane", "Kane", "Jerry" }
            };

            string[] a = strArr[0]; // 임시 배열을 만들어 0번 행의 값을 저장
            strArr[0] = strArr[2]; // 0번 행의 값을 2번 행으로 교체
            strArr[2] = a; // 2번 행은 0번 행이 저장된 임시 배열로 교체

            for (int i = 0; i < 3; i++) // 배열 출력
            {
                for (int j = 0; j < strArr[i].Length; j++) // 각 행의 길이에 맞춰서 출력
                {
                    Console.WriteLine($"strArr[{i}][{j}] = {strArr[i][j]}\n");
                }
            }

            Console.WriteLine("\n[2-6]\n");
            Console.Write("자연수 입력: ");
            string? num = Console.ReadLine(); // 입력한 값을 저장(문자열로 저장됨)

            int intNum = Convert.ToInt32(num); // 문자열로 저장된 값을 정수형으로 변환

            Console.WriteLine($"{Convert.ToString(intNum, 16)}\n\n"); // 16진수로 변환하여 출력
        }        
    }
}