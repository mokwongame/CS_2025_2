using System.Data;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem6();
        }

        static void Problem6()
        {
            Console.WriteLine("[6-2]\n");
            Point origin = new Point();
            Point p = new Point(2.0, 3.0);
            double distance = origin.GetDistance(p);
            Console.WriteLine($"두 점 사이의 거리: {distance:F2}");

            Console.WriteLine("\n[6-4]\n");
            Circle c = new Circle(3.0);
            Console.WriteLine($"원의 면적: {c.GetArea():F2}");
            Console.WriteLine($"원의 둘레: {c.GetCircumference():F2}");

            Console.WriteLine("\n[6-6]\n");
            SmartWatch sWatch = new SmartWatch(10, 30, "Sacramento_5G");
            sWatch.GetTime();
            sWatch.GetWifi();

            Console.WriteLine("\n[6-8]\n");
            Kingdom kdom = new Kingdom("David", 1000000);
            kdom.GetKing();
            kdom.GetPeopleNumber();
            Console.WriteLine(kdom.GetType());
        }

        class Point
        {
            public Point(double x = 0, double y = 0)
            {
                this.x = x;
                this.y = y;
            }

            public double GetDistance(Point p) // 두 점 사이의 거리 구하기
            {
                double x2 = Math.Abs(x - p.x); // 두 점의 x좌표의 차이를 구함
                double y2 = Math.Abs(y - p.y); // 두 점의 y좌표의 차이를 구함

                // 나온 값을 각각 제곱함
                x2 = Math.Pow(x2, 2);
                y2 = Math.Pow(y2, 2);

                // 제곱한 값을 더함
                double num = x2 + y2;

                // 더한 값의 제곱근을 구하면 두 점 사이의 거리가 나옴
                num = Math.Sqrt(num);

                return num;
            }

            double x;
            double y;
        }

        class Circle
        {
            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double GetArea() // 원의 넓이 구하기
            {
                return radius * radius * Math.PI;
            }

            public double GetCircumference() // 원의 둘레 구하기
            {
                return radius * 2 * Math.PI;
            }

            double radius;
        }

        class Watch
        {
            int hour;
            int minute;
            public void GetTime()
            {
                Console.WriteLine($"Time: [{hour}:{minute}]");
            }

            public void SetTime(int h, int m)
            {
                hour = h;
                minute = m;
            }
        }

        class SmartWatch : Watch
        {
            public SmartWatch(int h, int m, string ssid)
            {
                this.h = h;
                this.m = m;
                Wifi_SSID = ssid;

                SetTime(h, m);
            }
            public void GetWifi()
            {
                Console.WriteLine($"Connecting to {Wifi_SSID}");
            }

            int h;
            int m;
            string? Wifi_SSID;
        }

        class Kingdom
        {
            public Kingdom(string k, int nmbr)
            {
                king = k;
                peopleNumber = nmbr;
            }

            public void GetKing()
            {
                Console.WriteLine($"king: {king}");
            }

            public void GetPeopleNumber()
            {
                Console.WriteLine($"People Number: {peopleNumber}");
            }

            string? king;
            int peopleNumber;
        }
    }
}