using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Bridge
{
    public class SqlServer : ADataBank
    {

        /// <summary>
        /// @return
        /// </summary>
        public override string Convert()
        {

            //查询数据
            string sql = "XXXXX";

            DataTable data = this.GetData(sql);

            //保存文件,得到保存路径
            string filePath = base.file.SaveFile(data);

            //返回保存路径
            return filePath;
        }

    }
}