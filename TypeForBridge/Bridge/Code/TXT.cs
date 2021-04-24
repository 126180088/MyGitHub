
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Bridge;
using static System.Net.Mime.MediaTypeNames;


namespace Bridge
{
    public class TXT : IFileType
    {

        /// <summary>
        /// 将数据保存为txt格式
        /// </summary>
        /// <param name="data">保存数据</param>
        /// <returns></returns>
        public string SaveFile(DataTable tb)
        {
            string filePath = "/Users/huangqiwei/Projects/Bridge/BridgeMyFile.txt";

            StreamWriter sr;


            if (File.Exists(filePath))   //如果文件存在,则创建File.AppendText对象   
            {
                sr = File.AppendText(filePath);
            }
            else   //如果文件不存在,则创建File.CreateText对象   
            {
                sr = File.CreateText(filePath);
            }
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in tb.Rows)
            {
                sr.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" + dr[2].ToString() + "\t" + dr[3].ToString() + "\t" + dr[4].ToString() + "\t" + dr[5].ToString() + "\r\n");

            }
            sr.Close();

            return filePath;
        }

    }
}