using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bridge
{

    public abstract class ADataBank
    {

        private string connString;

        //关联对象：文件类型
        protected IFileType file;




        /// <summary>
        /// 抽象方法，数据转换
        /// </summary>
        /// 文件转换后文件的路径
        public abstract string Convert();


        /// <summary>
        /// @param string 
        /// @return
        /// </summary>
        public DataTable GetData(string sql)
        {

            //实例化链接
            MySqlConnection con = new MySqlConnection(sql);

            //开启链接
            con.Open();

            //获取数据
            string strcmd = "select * from WeeklyLog";

            MySqlCommand cmd = new MySqlCommand(strcmd, con);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            //建立表单保存数据
            DataTable dt = new DataTable();

            //查询结果填充数据集
            ada.Fill(dt);

            return dt;
        }

        /// <summary>
        /// @param IFileType 
        /// @return
        /// </summary>
        public IFileType SetFileType(IFileType type)
        {

            this.file = type;

            return file;
        }

    }
}

