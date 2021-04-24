
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bridge
{
    public interface IFileType
    {

        /// <summary>
        /// 保存数据
        /// </summary>
        public string SaveFile(DataTable data);

    }
}