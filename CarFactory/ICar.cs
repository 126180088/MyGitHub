///////////////////////////////////////////////////////////
//  ICar.cs
//  Implementation of the Interface ICar
//  Generated by Enterprise Architect
//  Created on:      25-3月-2021 20:56:37
//  Original author: zeng
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace VhFactory
{
	public interface ICar  {

		//返回具体产品的抽象接口
		ACar GetCar();
	}//end ICar
}
