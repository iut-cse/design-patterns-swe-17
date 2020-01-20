package fileparser;

import static org.junit.Assert.*;

import org.junit.Test;

public class SjonParserTest {

	
	@Test
	public void sjson() {
		String filepath = "sjsonfile.sjson";
		Parser p = new ParserFactory().createParser(filepath);
		assertEquals(p.getitemcount(), 3);
		assertEquals(p.getdata(1), "Aeroflot,1197672318,76,14,128");
	}

}
