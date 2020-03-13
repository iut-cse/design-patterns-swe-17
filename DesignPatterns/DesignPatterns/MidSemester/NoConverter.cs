using System;


public class NoConverter : IConverter
{

	public string Convert(string data)
	{
		return data;
	}

}
