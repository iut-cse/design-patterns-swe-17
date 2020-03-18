using DesignPattern.Midsemester;

namespace DesignPatterns.MidSemester
{

	public class Encrypt : ConvertionDecorator
	{
		public Encrypt(IConverter wrappee)
			: base(wrappee)
		{

		}

		protected override string SelfConvert(string data)
		{
			return data.ToLower();
			
		}

	}
}