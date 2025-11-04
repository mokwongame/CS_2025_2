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
