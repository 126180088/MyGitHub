
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirForBridge
{
    public abstract class APlaneMakers {

        protected IPlane Plane;


        /// <summary>
        /// 输出飞机类型与制造商
        /// </summary>
        public abstract void Convent();

        /// <summary>
        /// 确认飞机类型
        /// </summary>
        public void SetPlane(IPlane plane) {
            this.Plane = plane;
        }

    }
}