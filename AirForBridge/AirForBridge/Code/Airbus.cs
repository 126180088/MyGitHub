
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AirForBridge {

    public class Airbus : APlaneMakers {


        /// <summary>
        /// 输出制造商与飞机
        /// </summary>
        public override void Convent() {

            //输出制造商
            Console.Write("空客");

            //输出飞机
            this.Plane.DoPlane();
        }

    }
}