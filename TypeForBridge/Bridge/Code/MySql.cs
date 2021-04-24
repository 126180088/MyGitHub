using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bridge {

    public class MySql : ADataBank {
        /// <summary>
        /// Mysql的连接语句
        /// </summary>
        public override string Convert() {

            //连接mysql数据库
            string sql = "Server=localhost;User ID=root;Password=12345678;Database=mysql;";

            // 获取数据
            DataTable data = this.GetData(sql);

            //数据转换
            string filePath =  file.SaveFile(data);

            return filePath;
        }

    }

}

