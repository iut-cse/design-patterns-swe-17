using System;
using System.Collections.Generic;

public interface IConverter
{
	string Convert(string data);
}

public class NoConverter : IConverter
{

	public string Convert(string data)
	{
		return data;
	}

}




