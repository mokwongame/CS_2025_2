using System.Runtime.InteropServices;

namespace MyInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example8();
            //Console.WriteLine("Hello, World!");
        }

        static void Example8()
        {
            Sandisk sandisk = new Sandisk();
            sandisk.USBRead();
            sandisk.USBWrite();
            sandisk.DisplayManufacturer();

            IUSB usb = sandisk as IUSB; // updasting(자식 -> 부모)
            usb.USBRead();
            usb.USBWrite();
            //usb = new IUSB();
        }

        interface IUSB
        {
            void USBRead();
            void USBWrite();
        }

        class Sandisk : IUSB
        {
            // interface 메소드의 구현
            public void USBRead()
            {
                Console.WriteLine("Read data");
            }
            public void USBWrite()
            {
                Console.WriteLine("Write data");
            }

            public void DisplayManufacturer()
            {
                Console.WriteLine("by Sandisk");
            }
        }
    }
}
