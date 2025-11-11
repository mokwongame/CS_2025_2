using ProcessingUnits;

namespace MyCapsule
{
    // interal: 같은 어셈블리(exe, dll 파일) 안에서 해당 클래스를 접근할 수 있음
    internal class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU();
        }
    }
}
