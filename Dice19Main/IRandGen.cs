using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    // 인터페이스: 최고의 추상 클래스; 구현하지 않고 메소드의 호출 관계만 정의
    internal interface IRandGen
    {
        // 난수인 정수를 얻기
        int GetRand(); // 추상 메소드: 상속시 구현을 강제
    }
}
