package fileparser;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class ScsvParserTest {
	@Test
	public void scsv() {
		Parser p = new ScsvParser("csvfile.scsv");
		assertEquals(p.getitemcount(), 3);
		assertEquals(p.getdata(1), "Aeroflot,1197672318,76,14,128");
	}
}
