using DesignPatterns.MidSemester.problem2;

public class NoConversion : IConversion
{
    string text;
    public NoConversion(string text)
    {
        this.text = text;
    }

    public string GetString()
    {
        return text;
    }
}

