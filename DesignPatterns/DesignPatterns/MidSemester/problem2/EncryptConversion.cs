using DesignPatterns.MidSemester.problem2;

public class EncryptConversion : TextDecorator
{

    string text;

    public EncryptConversion(IConversion wrapee) : base(wrapee) => this.text = wrapee.GetString().ToLower();

    public override string GetString()
    {
        return text;
    }
}

