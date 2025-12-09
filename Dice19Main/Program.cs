namespace Dice19Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "Dice19Game.txt";

            // 게임 포인트를 파일에서 읽기
            TextReader reader = File.OpenText(filename);
            string sGamePoint = reader.ReadLine() ?? "";
            int gamePoint = int.Parse(sGamePoint);
            reader.Close(); // 파일 닫기

            // 게임 포인트 초기화
            GameManager.Instance.GamePoint = gamePoint;

            // 클래스(레퍼런스 자료형) 사용 -> 인스턴스 생성(new)
            Dice19Console console = new Dice19Console();
            console.Start();

            // 게임 포인트를 파일에 저장
            TextWriter writer = File.CreateText(filename); // 텍스트(text) 파일을 생성(create)
            // writer는 stream이라서 Console처럼 사용하면 됨
            writer.WriteLine(GameManager.Instance.GamePoint);
            writer.Close(); // 파일 닫기
        }
    }
}
