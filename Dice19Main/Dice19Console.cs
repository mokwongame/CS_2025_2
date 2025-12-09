using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class Dice19Console
    {
        public Dice19Console() { }

        public void Start()
        {
            ShowLogo();
            while (true)
            {
                ShowMenu();
                char input = SelectMenu();
                bool isExit = false;
                switch (input)
                {
                    case '1':
                        PlayDice19();
                        break;
                    case '2':
                        GetPoint();
                        break;
                    case '3':
                        ShowStat();
                        break;
                    case '4':
                        isExit = true;
                        break;
                }
                if (isExit) break; // 무한 루프를 빠져나가기 위한 break
            }
        }

        protected void PlayDice19()
        {
            Dice19Game game = new Dice19Game();
            game.Start();
        }

        protected void GetPoint()
        {
            CoinGame game = new CoinGame();
            game.Start();
        }

        protected void ShowStat()
        {
            MgLib.TextOutLine($"\n현재 게임 포인트 = {GameManager.Instance.GamePoint}\n", ConsoleColor.Magenta);
        }

        protected char SelectMenu()
        {
            char input = MgLib.Input("원하는 메뉴를 선택하세요: ", ConsoleColor.White);
            return input;
        }

        protected void ShowMenu()
        {
            ConsoleColor textCol = ConsoleColor.Green;
            MgLib.TextOutLine("==============", textCol);
            MgLib.TextOutLine("1. 주사위 19 게임", textCol);
            MgLib.TextOutLine("2. 포인트 모으기", textCol);
            MgLib.TextOutLine("3. 게임 통계", textCol);
            MgLib.TextOutLine("4. 게임 종료", textCol);
            MgLib.TextOutLine("==============", textCol);
        }

        protected void ShowLogo()
        {
            // 로고: ASCII art generator 사용
            // 주의점: \를 쓰는 경우는 @""(\를 그대로 출력)를 사용
            ConsoleColor textCol = ConsoleColor.Magenta;
            MgLib.TextOutLine("___ ____    _ _____", textCol);
            MgLib.TextOutLine(@"|  \/  | |  | | __ \", textCol);
            MgLib.TextOutLine(@"| .  . | |  | | |  \/", textCol);
            MgLib.TextOutLine(@"| |\/| | |/\| | | __", textCol);
            MgLib.TextOutLine(@"| |  | \  /\  / | _\ \", textCol);
            MgLib.TextOutLine(@"\_ |  | _ /\/  \/ \____ /", textCol);
        }
    }
}
