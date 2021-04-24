
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirForBridge
{
    public class CargoPlane : IPlane
    {
        /// <summary>
        /// 制造载货飞机
        /// </summary>
        public void DoPlane()
        {
            Console.WriteLine("正在制作载货飞机");
        }

    }
}