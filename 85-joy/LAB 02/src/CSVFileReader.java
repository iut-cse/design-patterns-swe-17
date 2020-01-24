import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;
import java.util.stream.Collectors;

public class CSVFileReader {
    List<String[]> read(String filepath) throws IOException {
        return Files.lines(Paths.get(filepath))
                .map(l -> l.split(","))
                .collect(Collectors.toList());
    }
}
