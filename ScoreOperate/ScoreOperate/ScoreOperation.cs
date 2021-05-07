
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ScoreOperate
{
    public interface ScoreOperation
    {
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="Number"></param>
        int[] Sort(int[] Number);

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Sorce"></param>
        bool Search(int[] Number, int Sorce);

        void AdapterOp();
    }
}