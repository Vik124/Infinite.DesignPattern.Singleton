using System;

namespace Infinite.DesignPattern.Singleton
{
    class Program
    {
        static CabService Customer1cabService = CabService.GetInstance();
        static CabService Customer2cabService = CabService.GetInstance();
        public static void Customer1NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 1 :{Customer1cabService.GetNextAvailableDriver()}");
        }

        public static void Customer2NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 2 :{Customer2cabService.GetNextAvailableDriver()}");
        }

        static void Main(string[] args)
        {
            CabService cabService = CabService.GetInstance();
            //Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");

            for (int i = 0; i < 4; i++)
            {
                // Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");
                Customer1NextDriver();
                Customer2NextDriver();
            }
        }
    }

}
