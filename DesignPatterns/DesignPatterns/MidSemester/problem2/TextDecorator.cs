using DesignPatterns.MidSemester.problem2;

public abstract class TextDecorator : IConversion
{
    protected IConversion wrapee;

    public TextDecorator(IConversion wrapee)
    {
        this.wrapee = wrapee;
    }
    public abstract string GetString();
    
}

