using System;

public class Class1
{
	public Class1()
	{namespace DesignPatterns.MidSemester
{
    public class Encrypt : FileDecorator
    {
        public Encrypt(IGamerStat gamerStat) : base(gamerStat)
        {

        }

        protected override string selfFileRead(string text)
        {
            return text.ToLower();
        }
    }
}

	}
}
