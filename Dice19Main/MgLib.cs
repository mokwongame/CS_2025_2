using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    // static class: 인스터스 만들지 않고 클래스의 static 멤버만으로 구성
    internal static class MgLib
    {
        // 배경색과 글자색을 바꾸어 출력
        public static void TextOut(string text, ConsoleColor textCol = ConsoleColor.Gray, ConsoleColor backCol = ConsoleColor.Black)
        {
            Console.BackgroundColor = backCol; // 배경색
            Console.ForegroundColor = textCol; // 전경색(글자색)
            Console.Write(text);
            Console.ResetColor();
        }
        public static void TextOutLine(string text, ConsoleColor textCol = ConsoleColor.Gray, ConsoleColor backCol = ConsoleColor.Black)
        {
            TextOut(text + '\n', textCol, backCol);
        }

        // 키보드로 문자 하나 입력
        public static char GetChar()
        {
            // Console.ReadLine(): 입력후 엔터를 쳐야 함 -> 불편
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            // 프로터티: 변수 역할이지만 메소드로 정의(클래스의 캡슐화를 편하게 지원)
            char ch = keyInfo.KeyChar; // keyInfo의 프로퍼티에 접근해서 문자 하나 얻기
            return ch;
        }

        public static char Input(string prompt, ConsoleColor textCol = ConsoleColor.Gray, ConsoleColor backCol = ConsoleColor.Black, bool insertLine = true)
        {
            if (prompt.Length > 0) TextOut(prompt, textCol, backCol);
            char input = GetChar();
            if (insertLine) Console.WriteLine("");
            return input;
        }
    }
}
