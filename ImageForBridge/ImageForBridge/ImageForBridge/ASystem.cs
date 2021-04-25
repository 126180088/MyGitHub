
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ImageForBridge
{
    public abstract class ASystem
    {
        protected IIamge Imp;


        /// <summary>
        /// 注入Image
        /// </summary>
        public void SetImage(IIamge Image)
        {
            this.Imp = Image;
        }

        /// <summary>
        /// 转换为像素矩阵，显示像素矩阵
        /// </summary>
        public abstract void ParseFile(string FileName);

    }
}