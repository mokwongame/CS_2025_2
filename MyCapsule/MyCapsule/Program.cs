using ProcessingUnits;
using Vehicle;

namespace MyCapsule
{
    // interal: 같은 어셈블리(exe, dll 파일) 안에서 해당 클래스를 접근할 수 있음
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem7();
            //CPU cpu = new CPU();
            //Example7();
        }

        static void Problem7()
        {
            Console.WriteLine("[7-1]\n");
            Car car = new Car();
            car.Run();
            car.Stop();

            Console.WriteLine("\n[7-3]\n");
            Finder finder = new Finder();
            Console.WriteLine(finder.Max(3, 4));
            Console.WriteLine(finder.Max(5, 4, 9));
            Console.WriteLine(finder.Max(new int[] { 83, 12, 99, 54 }));

            Console.WriteLine("\n[7-5]\n");
            Phone phone;
            CellPhone cellPhone = new CellPhone();
            SatellitePhone satellitePhone = new SatellitePhone();

            phone = cellPhone as Phone; // upcasting(자식 -> 부모)
            phone.Ring();
            phone = satellitePhone as Phone; // upcasting(자식 -> 부모)
            phone.Ring();

            Console.WriteLine("\n[7-7]\n");
            double meter = 2_000;
            double mile = 3.1;
            double result;
            result = LengthConverter.MeterToMile(meter);
            Console.WriteLine($"{meter} meter is {result:F2} mile.");
            result = LengthConverter.MileToMeter(mile);
            Console.WriteLine($"{mile} mile is {result:F2} meter.");

            Console.WriteLine("\n[7-9]\n");
            PrintCore printCore = new PrintCore();
            printCore.Print("Document");
        }

        static void Example7()
        {
            //Human human = new Human(); // 불가능: 추상 메소드의 구현이 없음
            Korean kr = new Korean();
            kr.SayHello();
            Human human = kr as Human;
            human.SayHello(); // upcasting(자식 -> 부모) 결과

            American am = new American();
            am.SayHello();
            human = am as Human;
            human.SayHello();
        }

        sealed class PrintCore
        {
            public void Print(string s)
            {
                Console.WriteLine(s);
            }
        }

        //class SamsungPrint : PrintCore { }

        static class LengthConverter
        {
            static readonly double meterPerMile = 1_609.43;

            static public double MeterToMile(double meter)
            {
                return meter / meterPerMile;
            }

            static public double MileToMeter(double mile)
            {
                return mile * meterPerMile;
            }
        }

        class Phone
        {
            virtual public void Ring()
            {
                Console.WriteLine("Phone ring.");
            }
        }

        class CellPhone : Phone
        {
            override public void Ring()
            {
                Console.WriteLine("Cellphone ring.");
            }
        }

        class SatellitePhone : Phone
        {
            override public void Ring()
            {
                Console.WriteLine("Satellite phone ring.");
            }
        }

        internal class Finder
        {
            public int Max(int a, int b)
            {
                return (a > b) ? a : b;
            }

            public int Max(int a, int b, int c)
            {
                if (a > b) // a가 최대값일 가능성
                {
                    return (a > c) ? a : c;
                }
                else // b가 최대값일 가능성
                {
                    return (b > c) ? b : c;
                }
            }

            public int Max(int[] arr)
            {
                int max = int.MinValue;
                foreach (var i in arr)
                    if (i > max) max = i;
                return max;
            }
        }

        abstract class Human
        {
            abstract public void SayHello();
        }

        class Korean : Human
        {
            override public void SayHello()
            {
                Console.WriteLine("안녕하세요.");
            }
        }

        class American : Human
        {
            override public void SayHello()
            {
                Console.WriteLine("Hello.");
            }
        }
    }
}
