using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class Dice19Game
    {
        public Dice19Game() { }

        public void Start()
        {
            MgLib.TextOutLine("주사위 19 게임", ConsoleColor.Cyan, ConsoleColor.DarkRed);
            while (true)
            {
                char input = MgLib.Input("게임을 종료하려면 X, 시작하려면 그외 키를 누르세요.");
                if (input == 'x' || input == 'X') break;
                bool result = Play();
                // 게임 결과에 따라 게임 포인트 갱신
                if (result) GameManager.Instance.GamePoint += 100;
                else GameManager.Instance.GamePoint -= 100;
            }
        }

        protected bool Play()
        {
            int pos = 0; // 주사위 위치
            bool iCallCheck = false;
            bool comCallCheck = false;
            int myCheckPos = 0;
            int comCheckPos = 0;
            Dice dice = new Dice(); // 주사위 인스턴스 생성
            while (true)
            {
                // 플레이어 차례
                MgLib.Input("주사위를 던지려면 아무키나 누르세요.", ConsoleColor.Blue);
                int myDice = dice.GetRand();
                MgLib.TextOutLine($"현재 나온 주사위값은 {myDice}입니다.", ConsoleColor.Blue);
                pos += myDice;
                myCheckPos = pos;
                MgLib.TextOutLine($"현재 주사위 위치는 {pos}입니다.", ConsoleColor.Red);
                if (pos > 19 || comCallCheck)
                {
                    break;
                }
                char input = MgLib.Input("체크를 하려면 C를 누르세요. 계속 하려면 그외 키.");
                if (input == 'c' || input == 'C')
                {
                    iCallCheck = true;
                    MgLib.TextOutLine($"플레이어가 체크를 불렀습니다.", ConsoleColor.Blue);
                }
                // 컴퓨터 차례
                MgLib.TextOutLine("컴퓨터가 주사위를 던집니다.", ConsoleColor.Green);
                // 잠시 정지: Sleep() 메소드 사용
                Thread.Sleep(1000);
                int comDice = dice.GetRand();
                MgLib.TextOutLine($"컴퓨터의 주사위값은 {comDice}입니다.", ConsoleColor.Green);
                pos += comDice;
                comCheckPos = pos;
                MgLib.TextOutLine($"현재 주사위 위치는 {pos}입니다.", ConsoleColor.Red);
                if (pos > 19 || iCallCheck)
                {
                    break;
                }
                if (JudgeCheck(pos))
                {
                    comCallCheck = true;
                    MgLib.TextOutLine($"컴퓨터가 체크를 불렀습니다.", ConsoleColor.Green);
                }
            }
            // 승패 판정
            return JudgeGame(myCheckPos, comCheckPos);
        }

        // 체크할지말지 판정
        protected bool JudgeCheck(int pos)
        {
            if (pos >= 16 && pos <= 19) return true;
            //if (pos >= 17 && pos <= 19) return true;
            else return false;
        }

        // 게임 승패 판정
        protected bool JudgeGame(int myPos, int comPos)
        {
            if (myPos > 19)
            {
                MgLib.TextOutLine($"플레이어 패배.", ConsoleColor.White, ConsoleColor.Red);
                return false;
            }
            else if (comPos > 19)
            {
                MgLib.TextOutLine($"컴퓨터 패배.", ConsoleColor.White, ConsoleColor.Blue);
                return true;
            }
            else if (19 - myPos < 19 - comPos)
            {
                MgLib.TextOutLine($"플레이어 승리.", ConsoleColor.White, ConsoleColor.Blue);
                return true;
            }
            else
            {
                MgLib.TextOutLine($"컴퓨터 승리.", ConsoleColor.White, ConsoleColor.Red);
                return false;
            }
        }
    }
}
