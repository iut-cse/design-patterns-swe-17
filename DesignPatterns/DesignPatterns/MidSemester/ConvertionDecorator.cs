
public class ConvertionDecorator : IConverter
{ 

    public ConvertionDecorator(IConverter wrappee)
    {
        this.wrappee = wrappee;
    }

    public string Convert(string data)
    {
        return wrappee.Convert(data);
    }
}
