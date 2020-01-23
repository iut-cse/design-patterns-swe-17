import java.io.File;

public class sJSONParser implements IFileParser{
    public File file;
    public sJSONParser(String filePath)
    {
        this.file = new File(filePath);
    }

    @Override
    public String GetData() {
        return null;
    }

    @Override
    public int GetItemCount() {
        return 0;
    }
}
