using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = Car.getInstance();
            Car car2 = Car.getInstance();

            unsafe
            {
                TypedReference tr1 = __makeref(car1);
                TypedReference tr2 = __makeref(car2);
                IntPtr pt1 = **(IntPtr**)(&tr1);
                IntPtr pt2 = **(IntPtr**)(&tr2);
                Console.WriteLine($"car1 address: {pt1}");
                Console.WriteLine($"car2 address: {pt2}");
            }
            

            Console.WriteLine("car1 carNum:" + car1.getCarNum());
            Console.WriteLine("car2 carNum:" + car2.getCarNum());

            car1.setCarNum(111122);
            Console.WriteLine("=================================");
            Console.WriteLine("car1 carNum:" + car1.getCarNum());
            Console.WriteLine("car2 carNum:" + car2.getCarNum());

            car2.setCarNum(375614);
            Console.WriteLine("=================================");
            Console.WriteLine("car1 carNum:" + car1.getCarNum());
            Console.WriteLine("car2 carNum:" + car2.getCarNum());
        }
    }
}
