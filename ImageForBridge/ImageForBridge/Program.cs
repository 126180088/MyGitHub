using System;
using System.Configuration;
using System.Reflection;

namespace ImageForBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ASystem aSystem;//抽象系统

            IIamge iamge;//抽象图片格式

            //使用系统的控制反转
            string aSystemString = ConfigurationManager.AppSettings["AbsOs"];
            aSystem = (ASystem)Assembly.Load("ImageForBridge").CreateInstance(aSystemString);

            //使用图片格式的控制反转
            string iamgeString = ConfigurationManager.AppSettings["ImType"];
            iamge = (IIamge)Assembly.Load("ImageForBridge").CreateInstance(iamgeString);

            //注入图片
            aSystem.SetImage(iamge);

            //解析图片，显示矩阵
            aSystem.ParseFile("D:/照片.Png");

        }
    }
}
