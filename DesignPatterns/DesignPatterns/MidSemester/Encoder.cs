using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{


	public class Encoder : ConvertionDecorator
	{
		public Encoder(IConverter wrappee)
			: base(wrappee)
		{

		}

		protected override string SelfConvert(string data)
		{
			return "(" + data + ")";
		}

	}
}