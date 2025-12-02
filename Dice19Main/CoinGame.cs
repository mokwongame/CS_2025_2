using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class CoinGame
    {
        int point;
        public CoinGame()
        { point = 0; }

        public void Start()
        {
            while (true)
            {
                char input = MgLib.Input("동전의 앞면(F)이나 뒷면(B)을 선택하세요: ");
                input = char.ToUpper(input); // 대문자로 변환해서 저장
                MgLib.TextOut("동전을 던지려면 아무키나 누르세요: ", ConsoleColor.Yellow);
                MgLib.GetChar();
                Coin coin = new Coin();
                int coinVal = coin.GetRand(); // 0이면 B, 1이면 F
                char coinChar = Coin.ValToChar(coinVal);
                MgLib.TextOutLine($"동전은 {coinChar}면이 나왔습니다.", ConsoleColor.Yellow);
                if (input == coinChar) // 성공
                {
                    MgLib.TextOutLine("잘 맞추었습니다.", ConsoleColor.Blue);
                    point += 2;
                }
                else // 실패
                {
                    MgLib.TextOutLine("틀렸습니다.", ConsoleColor.Red);
                    point--;
                }
                input = MgLib.Input("끝내려면 X를 누르세요. 계속 하려면 다른 키를 누르세요: ");
                if (input == 'x' || input == 'X') break; // 무한 루프를 빠져나가는 break
            }
        }
    }
}
