using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem6();
            //Example6();
        }

        static void Problem6()
        {
            Console.WriteLine("[6-1]\n");
            Person1 tom = new Person1("Tom", 23, "Seoul");
            Console.WriteLine($"이름: {tom.GetName()}");
            Console.WriteLine($"나이: {tom.GetAge()}");
            Console.WriteLine($"도시: {tom.GetCity()}");

            Console.WriteLine("\n[6-3]\n");
            Product ramen = new Product("rm001", 3000);
            Product juice = new Product("jc021", 4000);
            Console.WriteLine(Product.GetFactoryName());
            Console.WriteLine(Product.GetProductCount());
            Console.WriteLine(ramen.GetProductID());
            Console.WriteLine(juice.GetPrice());

            Console.WriteLine("\n[6-4]\n");
            double x = Math.PI; // 원주율
            Console.WriteLine($"pi = {x}");
            Console.WriteLine($"pi = {x:F3}"); // 소수점 3자리까지 출력

            Console.WriteLine("\n[6-5]\n");
            ElectricCar eCar = new ElectricCar(500);
            eCar.Run();
            eCar.Charge();

            Console.WriteLine("\n[6-7]\n");
            SmartPhone sPhone = new SmartPhone("010-1234-5678", "Sacramento_5G");
            sPhone.Call("010-9876-5432");
            sPhone.ConnectWifi();
        }

        class Phone
        {
            public Phone(string number)
            {
                this.number = number;
            }

            public void Call(string num)
            {
                Console.WriteLine($"Calling {num}");
            }

            public void Receive()
            {
                Console.WriteLine("Receive");
            }

            string number;
        }

        class SmartPhone : Phone
        {
            public SmartPhone(string number, string ssid) : base(number) // 부모 클래스(base)의 생성자 호출
            {
                Wifi_SSID = ssid;
            }

            public void ConnectWifi()
            {
                Console.WriteLine($"Connecting to {Wifi_SSID}");
            }

            string Wifi_SSID;
        }

        class Vehicle
        {
            public void Run()
            {
                Console.WriteLine("Run");
            }

            public void Stop()
            {
                Console.WriteLine("Stop");
            }
        }

        class ElectricCar : Vehicle
        {
            public ElectricCar(int cap)
            {
                batteryCapacity = cap;
            }

            public void Charge()
            {
                Console.WriteLine($"Charging {batteryCapacity} kWh");
            }

            int batteryCapacity;
        }

        class Product
        {
            static Product()
            {
                Product.factory = "KFood";
                Product.numInst = 0;
            }

            public Product(string id, uint price)
            {
                this.id = id;
                this.price = price;
                Product.numInst++;
            }

            public static string GetFactoryName()
            {
                return Product.factory;
            }

            public static uint GetProductCount()
            {
                return Product.numInst;
            }

            public string GetProductID()
            {
                return id;
            }

            public uint GetPrice()
            {
                return price;
            }

            string id;
            uint price;
            static readonly string factory;
            static uint numInst; // 인스턴스 개수
        }

        class Person1
        {
            public Person1(string name, int age, string city)
            {
                this.name = name;
                this.age = age;
                this.city = city;
            }

            public string GetName()
            {
                //return this.name;
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

            // 필드: public을 하지 않는 것이 원칙(캡슐화)
            string name;
            int age;
            string city;
        }

        static void Example6()
        {
            // 클래스 할당: 레퍼런스로만 할당
            Person p1 = new Person(); // 인스턴스를 새로(new) 만들어서 레퍼런스를 p1에 할당(=)
            p1.age = 20;
            Person p2 = p1; // class라서 할당은 무조건 레퍼런스로만 이루어짐
            Console.WriteLine($"p1 = {p1.age}, p2 = {p2.age}");
            p2.age = 30;
            Console.WriteLine($"p1 = {p1.age}, p2 = {p2.age}\n");

            // 구조체 할당
            Animal a1 = new Animal();
            a1.age = 20;
            Animal a2 = a1; // 값으로 할당
            Console.WriteLine($"a1 = {a1.age}, a2 = {a2.age}");
            a2.age = 30;
            Console.WriteLine($"a1 = {a1.age}, a2 = {a2.age}\n");

            // 복제되는 클래스 예시
            PersonClone pc1 = new PersonClone(); // 인스턴스를 새로(new) 만들어서 레퍼런스를 p1에 할당(=)
            pc1.age = 20;
            //PersonClone pc2 = pc1; // class라서 할당은 무조건 레퍼런스로만 이루어짐
            PersonClone pc2 = pc1.Clone() as PersonClone;
            Console.WriteLine($"pc1 = {pc1.age}, pc2 = {pc2.age}");
            pc2.age = 30;
            Console.WriteLine($"pc1 = {pc1.age}, pc2 = {pc2.age}\n");
        }
    }

    class Person
    {
        // 멤버 변수: 필드(field)
        public string? name;
        public int age = 10;
    }

    class PersonClone : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // 멤버 변수: 필드(field)
        public string? name;
        public int age = 10;
    }

    struct Animal
    {
        public Animal()
        { }

        public int age = 10;
    }
}
