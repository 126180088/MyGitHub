
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImageForBridge.ImageForBridge;

namespace ImageForBridge
{
    public class Png : IIamge
    {


        /// <summary>
        /// 显示像素矩阵
        /// </summary>
        public void GoImage(Matrix matrixm)
        {
            Console.WriteLine("显示Png图片的像素矩阵");
        }

    }
}