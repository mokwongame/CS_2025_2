namespace TestClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise6();
        }

        static void Exercise6()
        {
            Person tom = new Person("Tom", 23, "Seoul");

            Console.WriteLine("이름:" + tom.GetName());
            Console.WriteLine("나이: " + tom.GetAge());
            Console.WriteLine("도시:" + tom.GetCity());

            ElectricCar eCar = new ElectricCar(500);
            eCar.Run();
            eCar.Charge();

            SmartWatch sWatch = new SmartWatch(10, 30, "Sacramento_5G");
            sWatch.GetTime();
            sWatch.GetWifi();

        }

        class Vehicle
        {
            public void Run() { Console.WriteLine("Run"); }
            public void Stop() { Console.WriteLine("Stop"); }
        }

        class ElectricCar : Vehicle
        {
            int batteryCapacity;

            public ElectricCar(int c)
            {
                batteryCapacity = c;
            }

            public void Charge()
            {
                Console.WriteLine("Charging " + batteryCapacity + " kWh");
            }
        }

        class Person
        {
            const double x = Math.PI;
            string name;
            int age;
            string city;


            public Person(string name, int age, string city)
            {
                this.name = name;
                this.age = age;
                this.city = city;
            }

            public string GetName()
            {
                Console.WriteLine($"{Person.x,10:F5}");
                return name;
            }

            public int GetAge()
            {
                return age;
            }

            public string GetCity()
            {
                return city;
            }
        }

        class Watch
        {
            public int hour;
            public int minute;

            public void GetTime()
            {
                Console.WriteLine($"Time:{hour}:{minute} ");
            }
            public void SetTime(int h, int m)
            {
                this.hour = h;
                this.minute = m;
            }
        }

        class SmartWatch : Watch
        {
            public string wifi_SSID;
            public SmartWatch(int h, int m, string ssid)
            {
                SetTime(h, m);
                this.wifi_SSID = ssid;
            }
            public void GetWifi()
            {
                Console.WriteLine($"Wifi: {wifi_SSID}");
            }
        }

    }
}
