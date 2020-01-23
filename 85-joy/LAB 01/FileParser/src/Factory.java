public class Factory {
    IFileParser fileParser;
    public IFileParser CreateFileParser(String filePath)
    {
        if(filePath.endsWith(".scsv"))
            fileParser = new sCSVParser(filePath);
        else if(filePath.endsWith(".sjson"))
            fileParser = new sJSONParser(filePath);
        else
            fileParser = null;
        return fileParser;
    }
}
