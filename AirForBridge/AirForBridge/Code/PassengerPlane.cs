
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AirForBridge
{
    public class PassengerPlane : IPlane
    {
        /// <summary>
        /// 制造载客飞机
        /// </summary>
        public void DoPlane()
        {
            Console.WriteLine("正在制作载客飞机");
        }

    }
}