using System;

namespace AirForBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //桥接模式的使用
            APlaneMakers aPlaneMakers = new Boeing();

            //给对象注入关联对象
            IPlane plane = new PassengerPlane();
            aPlaneMakers.SetPlane(plane);

            //执行制造
            aPlaneMakers.Convent();

            Console.Read();
        }
    }
}
