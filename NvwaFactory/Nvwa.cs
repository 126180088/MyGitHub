///////////////////////////////////////////////////////////
//  Nvwa.cs
//  Implementation of the Interface Nvwa
//  Generated by Enterprise Architect
//  Created on:      19-3月-2021 14:59:32
//  Original author: 黄芪炜
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using NvwaFactory;

namespace NvwaFactory
{
    class Factory
    {
        //静态工厂方法
        public static IPerson GetPerson(string type)
        {
            IPerson product = null;
            if (type.Equals("M"))
            {
                product = new Man();
                //初始化设置Person
            }
            else if (type.Equals("W"))
            {
                product = new Woman();
                //初始化设置Person
            }
            else if (type.Equals("R"))
            {
                product = new Robot();
                //初始化设置Person
            }
            return product;
        }
    }
}//end Nvwa
