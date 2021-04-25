
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImageForBridge.ImageForBridge;

namespace ImageForBridge
{
    public class Windows : ASystem
    {
        /// <summary>
        /// 解析图片 显示像素矩阵
        /// </summary>
        public override void ParseFile(string FileName)
        {
            //显示操作系统
            Console.Write("正在Windows系统中");

            //模拟转换为矩阵
            Matrix maritx = new Matrix();

            //显示像素矩阵
            Imp.GoImage(maritx.GoMatrix(FileName));
        }

    }
}