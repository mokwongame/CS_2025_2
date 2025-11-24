using System;

namespace PartialClassExample
{
    public partial class Employee
    {
        private int salary;
        private string department;

        public Employee(int salary, string department)
        {
            this.salary = salary;
            this.department = department;
            Console.WriteLine($"Employee created: Salary={this.salary}, Dept={this.department}");
        }

        public void GotoWork()
        {
            Console.WriteLine("Go to Work");
        }
    }

    public partial class Employee
    {
        public void LeaveTheOffice()
        {
            Console.WriteLine("Leave the office");
        }
    }
}

namespace Chapter7
{
    public class Coin
    {
        private string manufacturer;
        protected int value;
        internal string material;
        public string country;

        public Coin(string mnfctr, int vl, string mtrl, string cntr)
        {
            manufacturer = mnfctr;
            value = vl;
            material = mtrl;
            country = cntr;
        }

        public Coin(string mnfctr)
        {
            manufacturer = mnfctr;
        }

        private void SetManufacturer(string mnfctr)
        {
            this.manufacturer = mnfctr;
        }

        public void GetCoinInfo()
        {
            Console.WriteLine($"- Manufacturer: {manufacturer}");
            Console.WriteLine($"- Value: {value}");
            Console.WriteLine($"- Material: {material}");
            Console.WriteLine($"- Country: {country}");
        }
    }

    public class HundredWon : Coin
    {
        public HundredWon(string mnfctr, int vl, string mtrl, string cntr)
            : base(mnfctr, vl, mtrl, cntr)
        {
            Console.WriteLine($"HundredWon created (Value: {this.value})");
        }
    }

    public class Shape
    {
        public virtual double GetArea()
        {
            Console.Write("Shape Area: ");
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double GetArea()
        {
            Console.Write("Rectangle Area: ");
            return width * height;
        }
    }

    public class Computer
    {
        private double GetOS()
        {
            Console.Write("Operating System: ");
            return 10.0;
        }

        public string GetOSName()
        {
            return "Windows 11";
        }

        public class CPU
        {
            public void GetID()
            {
                Console.WriteLine("CPU ID: Intel-i7-12700K");
            }
        }
    }

    public abstract class AbstractComputer
    {
        public abstract void InstallOS(string os);
    }

    public class LapTop : AbstractComputer
    {
        public override void InstallOS(string os)
        {
            Console.WriteLine($"{os}가 설치되었습니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Problem7_Even();
        }

        static void Problem7_Even()
        {
            Console.WriteLine("--- [7-2] Coin / HundredWon 접근 제한자 연습 ---");
            HundredWon hWon = new HundredWon("KoreaBank", 100, "Cu", "Korea");
            hWon.GetCoinInfo();

            Coin coin = hWon;
            coin.country = "USA";
            coin.GetCoinInfo();
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\n--- [7-4] Shape / Rectangle GetArea 오버라이딩 ---");
            Rectangle rectangle = new Rectangle(2.5, 4);
            Console.WriteLine(rectangle.GetArea());

            Shape sh = rectangle as Shape;
            Console.WriteLine(sh.GetArea());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\n--- [7-6] Computer 중첩 클래스 CPU ---");
            Computer cmptr = new Computer();
            Console.WriteLine(cmptr.GetOSName());

            Computer.CPU cpu = new Computer.CPU();
            cpu.GetID();
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\n--- [7-8] AbstractComputer 추상 메서드 InstallOS ---");
            LapTop laptop = new LapTop();
            laptop.InstallOS("Windows");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\n--- [7-10] partial class Employee ---");
            PartialClassExample.Employee kim = new PartialClassExample.Employee(50000, "RnD");
            kim.GotoWork();
            kim.LeaveTheOffice();
            Console.WriteLine("-------------------------------------------------");
        }
    }
}