public class File_Parser {
    String f_extension;
    Parser getParser()
    {
        if(f_extension == "sjson")
        {
                    return new SJSON();
        }
        else if(f_extension == "scsv")
        {
                    return new SCSV();
        }
        return null;
    }
}
