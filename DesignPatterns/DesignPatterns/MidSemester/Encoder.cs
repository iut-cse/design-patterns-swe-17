using System;
using System.Collections.Generic; 

public class Encoder : ConvertionDecorator
{
	public Encoder(IConverter wrappee)
		: base(wrappee)
    {

    }

	public override string Convert(string data)
	{
		data = "(" + data + ")";
		return base.Convert(data);
	}

}