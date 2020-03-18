using DesignPattern.Midsemester;

namespace DesignPatterns.MidSemester
{

	public class Compressor : ConvertionDecorator
	{

		public Compressor(IConverter wrappee)
			: base(wrappee)
		{

		}

		protected override string SelfConvert(string data)
		{
			if (data.Length >- 3)
			{
				data = data.Substring(0, data.Length - 2);
			}
			return data;
		}
	}
}