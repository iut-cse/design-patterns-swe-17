using System;
using DesignPattern.Midsemester;


public class NoConverter : IConverter
{

	public string Convert(string data)
	{
		return data;
	}

}
