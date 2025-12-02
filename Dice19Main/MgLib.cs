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
    }
}
