using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VhFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //申明工厂类
            ICar benzFactory = new BenzFactory();
            //工厂类创建具体类
            ACar car = benzFactory.GetCar();
            //使用获取的类的方法
            car.OpenCar();
            Console.Read();
        }
    }
}
