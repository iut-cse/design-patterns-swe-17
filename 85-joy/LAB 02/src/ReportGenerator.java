import java.io.IOException;
import java.util.List;
import java.util.Set;

public class ReportGenerator {
    public String filepath;
    public List<String[]> data;
    public String[] Department;
    public String[] Date;
    public String[] ClassHours;

    public ReportGenerator(String filepath)
    {
        this.filepath = filepath;
        SetData();
    }

    public void SetData()
    {
        CSVFileReader csvFileReader = new CSVFileReader();
        try {
            data = csvFileReader.read(filepath);
            this.Department = data.get(0);
            this.Date =  data.get(1);
            this.ClassHours = data.get(2);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
