using System;
using System.Configuration;
using System.Reflection;

namespace ScoreOperate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //针对抽象目标接口编程
            ScoreOperation operation; 
            //读取配置文件 ConfigurationManager
            string adapterType = ConfigurationManager.AppSettings["adapter"];
            //反射生成对象
            operation = (ScoreOperation)Assembly .Load("ScoreOperate").CreateInstance(adapterType);
            //需进行操作的数组
            int[] Number = { 70, 90, 60, 70, 80, 90 };
            //接受返回值的数组
            int[] number;
            //需查找的值
            int score = 100;
            //接受二分查找方法的返回值
            bool relust;
            //实例化
            operation.AdapterOp();
            //调用方法排序
            number = operation.Sort(Number);
            //输出数组
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            //接受查询返回值
            relust = operation.Search(Number, score);
            //判断结果
            if (relust)
            {
                //如果为真
                Console.WriteLine("查询成功");
            }
            else
            {
                Console.WriteLine("查询失败");
            }
        }
    }
}
