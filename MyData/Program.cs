// MyData의 내부 멤버에 접근하고 싶으면
// C++: #include <MyData.h>
// C#: using MyData; (Java 방식 채택: 컴파일러가 알아서 헤더를 추가)
namespace MyData
{
    internal class Program
    {
        static void Main(string[] args) // 프로그램의 시작점; 반드시 있어야 함
        {
            Console.WriteLine("정수 자료형");
            byte i1 = 10; // value type
            Console.WriteLine($"byte 변수 = {i1}\n"); // $ 문자열: printf(), cout와 비슷; {} 안에 있는 변수를 계산해서 문자열로 출력
            short i2 = 100; // short int; value type
            Console.WriteLine($"short 변수 = {i2}\n");
            int i3 = 1000;
            Console.WriteLine($"int 변수 = {i3}");
            Console.WriteLine($"int 최소값 = {int.MinValue}, int 최대값 = {int.MaxValue}\n");
            long i4 = 10000;
            Console.WriteLine($"long 변수 = {i4}\n");

            // 문자열 string과의 관계: Java 문법 사용
            string str1 = "1000";
            int i5 = int.Parse(str1); // 문자열 str1을 구문 분석해서(parse) 정수(int)로 변환
            Console.WriteLine($"string -> int = {str1} -> {i5}");
            string str2 = i5.ToString(); // 정수 인스턴스 i5를 문자열로(to string) 변환
            Console.WriteLine($"int -> string = {i5} -> {str2}");
        }
    }
}
