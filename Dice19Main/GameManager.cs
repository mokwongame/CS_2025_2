using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    // singleton pattern: 인스턴스가 단 하나만 존재하는 클래스
    internal sealed class GameManager // sealed: 상속받지 못하게 실링
    {
        private static GameManager? instance = null; // private field(필드)
        public static GameManager Instance // public property
        {
            get
            {
                if (instance == null) instance = new GameManager(); // 딱 한번만 메모리 할당하여 인스턴스를 하나만 생성
                return instance;
            }
            // set은 의도적으로 만들지 않음: singleton pattern
        }
        private GameManager() { } // private 생성자: 외부에서 호출이 불가능

        // 게임의 중요 변수를 선언
        public int GamePoint
        {
            get; set; // 자동 프로퍼티
        } = 10; // GamePoint 프로퍼티를 10으로 초기화
    }
}
