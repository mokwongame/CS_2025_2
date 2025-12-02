namespace Dice19Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MgLib.TextOutLine("Hello, World!", ConsoleColor.Red, ConsoleColor.White);
            // 클래스(레퍼런스 자료형) 사용 -> 인스턴스 생성(new)
            Dice19Console console = new Dice19Console();
            console.Start();
        }
    }
}
