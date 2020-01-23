import static org.junit.jupiter.api.Assertions.*;
import org.testng.annotations.Test;

public class UnitTests {

    @Test
    public void ItemCountTest()
    {
        Factory factory = new Factory();
        IFileParser fileParser = factory.CreateFileParser("E:\\A C A D E M I C\\IUT SWE\\SEM 5\\SWE    4501         DESIGN PATTERNS\\L A B\\design-patterns-swe-17\\85-joy\\LAB 01\\FileParser\\dataset\\example.scsv");

        assertEquals(3,fileParser.GetItemCount());
    }

}
