
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScoreLibs;

namespace ScoreOperate
{
    public class Adapter : ScoreOperation
    {

        private QuickSortClass sortObj;

        private BinarySearchClass searchObj;


        /// <summary>
        /// 排序
        /// </summary>
        public int[] Sort(int[] Number)
        {
            //调用排序方法，返回值为int[]
            int[] number=  sortObj.QuickSort(Number);

            return number;
        }

        /// <summary>
        /// 二分排序
        /// 二分查找方法，如果找到，返回 1，找不到返回-1
        /// </summary>
        public bool Search(int[] Number, int Sorce)
        {
            bool result;
            //调用二分查找方法，返回int类型的参数
            int number = searchObj.BinarySearch(Number, Sorce);
            //判断返回值为true还是false
            if (number == 1)
                result = true;
            else
                result = false;            
            return result;
        }

        /// <summary>
        /// 实例化
        /// </summary>
        public void AdapterOp()
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
        }

    }
}