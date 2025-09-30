// MyData의 내부 멤버에 접근하고 싶으면
// C++: #include <MyData.h>
// C#: using MyData; (Java 방식 채택: 컴파일러가 알아서 헤더를 추가)
namespace MyData
{
    internal class Program
    {
        static void Main(string[] args) // 프로그램의 시작점; 반드시 있어야 함
        {
            Problem2();
            Console.WriteLine("\n====================");

            TestArray(); // 클래스의 메소드 호출; static 멤버는 static 멤버만 호출 가능

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

            Console.WriteLine("\n실수 자료형");
            float x = 1.345678901234567890f; // float은 마지막에 f를 꼭 붙여야 함
            double y = 1.345678901234567890; // C언어와 동일
            decimal z = 1.345678901234567890m; // 새로운 실수 자료형: decimal 뜻 = 10진수 -> 10진수를 쓰는 실수
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            double y2 = 1_000_000_000; // 1,000,000,000
            Console.WriteLine($"y2 = {y2}");
            double y3 = double.Parse("-1.23456"); // string -> double
            Console.WriteLine($"y3 = {y3}");
            string str3 = y3.ToString(); // double -> string
            Console.WriteLine($"double -> string = {y3} -> {str3}");
            double y4 = 0.0;
            Console.WriteLine($"y3/0 = {y3 / y4}");
            Console.WriteLine($"0/0 = {y4 / y4}");

            Console.WriteLine("\n문자열");
            // 문자열: 레퍼런스형 자료형
            string str4 = "C# Programming"; // "..." 리터럴, str4는 레퍼런스형 변수; 예외적으로 string은 메모리 할당(new)할 필요 없음
            str4 = "C:\\Windows"; // \\ 의미: \ 문자
            Console.WriteLine(str4);
            str4 = @"D:\객체지향프로그래밍3"; // @ 문자열: 이스케이프 문자 처리 안함
            Console.WriteLine(str4);
            string str5 = str4; // 레퍼런스만 할당됨
            string str6 = "Coding";
            Console.WriteLine($"인덱싱: {str6[1]} : {str6[^1]}");
            Console.WriteLine($"슬라이싱: {str6[0..3]}");
        }

        static void TestArray() // 함수(메소드) 정의
        {
            // 정수 배열: 레퍼런스 자료형(할당할 때 new를 쓰든지 아니면 레퍼런스 필요)
            int[] intAr = new int[] { 10, 20, 30, 40 }; // 메모리 할당으로 초기화
            int[] intAr2 = intAr; // 레퍼런스로 초기화: 실행 속도 빠름(레퍼런스만 할당)
            // 배열을 복제(clone): 배열 원소를 모두 복사
            int[] intAr3 = (int[])intAr.Clone(); // 실행 속도 느림(모든 원소를 다 복사)

            intAr[0] = -10;
            Console.WriteLine($"intAr2[0] = {intAr2[0]}"); // 배열의 레퍼런스 할당: 누군가 접근해서 값을 바꿈
            Console.WriteLine($"intAr3[0] = {intAr3[0]}\n"); // 배열을 복제: 원래값 유지

        }

        // Person 구조체 정의
        struct Person
        {
            public string Name;
            public int Age;
        }

        static void Problem2()
        {
            Console.WriteLine("[2-1]\n");
            // 자료형 선택: 2차원 배열 int[,]
            int[,] intAr2 = new int[,] { { 2, 9, 1 }, { 10, 4, 7 } };
            int sum0 = intAr2[0, 0] + intAr2[1, 0]; // 0열 원소 더하기
            int sum1 = intAr2[0, 1] + intAr2[1, 1]; // 1열 원소 더하기
            int sum2 = intAr2[0, 2] + intAr2[1, 2]; // 2열 원소 더하기
            Console.WriteLine($"0열 합 = {sum0,-3:D}"); // 정수(D) 3자리(3) 왼쪽 맞춤(-)
            Console.WriteLine($"1열 합 = {sum1,-3:D}");
            Console.WriteLine($"2열 합 = {sum2,-3:D}");

            Console.WriteLine("\n[2-3]\n");
            Person person; // struct는 value형 자료형; 할당(=) 없이 그대로 사용 가능
            Console.Write("이름: ");
            string name = Console.ReadLine(); // 키보드 입력을 한 줄(line) 읽기(read)
            person.Name = name;
            Console.Write("나이: ");
            string age = Console.ReadLine();
            person.Age = int.Parse(age); // 문자열 -> 정수
            Console.WriteLine($"입력: 이름 = {person.Name}, 나이 = {person.Age}");
        }
    }
}
