import java.io.IOException;
import java.text.SimpleDateFormat;
import java.time.DateTimeException;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Calendar;
import java.util.List;

public class Main {
    public static void main(String[] args)
    {
        CSVFileReader csvFileReader = new CSVFileReader();
        //List<String[]> list = new List<String[]>();
        try {
            List<String[]> list = csvFileReader.read("E:\\A C A D E M I C\\IUT SWE\\SEM 5\\SWE    4501         DESIGN PATTERNS\\L A B\\design-patterns-swe-17\\85-joy\\LAB 02\\dataset\\dataset.csv");
            System.out.println(list.get(1)[1]);
            String input = list.get(1)[1];
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
            LocalDate localDate = LocalDate.parse(input , formatter);
            System.out.println(localDate.getDayOfWeek());


        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
