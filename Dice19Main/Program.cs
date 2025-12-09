namespace Dice19Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 게임 포인트 초기화
            GameManager.Instance.GamePoint = 100;

            // 클래스(레퍼런스 자료형) 사용 -> 인스턴스 생성(new)
            Dice19Console console = new Dice19Console();
            console.Start();
        }
    }
}
