using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //桥接模式使用
            ADataBank aDataBank = new MySql();//里式代换原则

            //给对象注入关联对象（具体实例）
            IFileType fileType = new TXT();

            aDataBank.SetFileType(fileType);

            //执行数据转换操作
            string filePath = aDataBank.Convert();

            Console.WriteLine(filePath);

            Console.Read();
        }
    }
}
