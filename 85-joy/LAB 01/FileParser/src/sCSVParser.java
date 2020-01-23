import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class sCSVParser implements IFileParser {
    public File file;
    public int counter = -1;

    public sCSVParser(String filePath)
    {
        this.file = new File(filePath);
    }
    @Override
    public String GetData() {
        return null;
    }

    @Override
    public int GetItemCount() {
        try {
            Scanner scanner = new Scanner(file);
            while(scanner.hasNextLine())
            {
                String temp = scanner.nextLine();
                counter ++;
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return counter;

    }
}
