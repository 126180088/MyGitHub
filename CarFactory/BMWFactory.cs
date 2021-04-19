///////////////////////////////////////////////////////////
//  BMWFactory.cs
//  Implementation of the Class BMWFactory
//  Generated by Enterprise Architect
//  Created on:      25-3��-2021 20:56:43
//  Original author: zeng
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace VhFactory
{
	public class BMWFactory : ICar
	{

		public BMWFactory()
		{

		}
		//���ɲ�����BMW��
		public ACar GetCar()
		{
			ACar car = new BMWCar();
			return car;
		}

	}//end BMWFactory
}