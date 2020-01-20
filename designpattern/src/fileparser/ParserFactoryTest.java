package fileparser;

import static org.junit.Assert.*;

import org.junit.Test;

public class ParserFactoryTest {

	@Test
	public void parserFactory() {
		Parser perser = new ParserFactory()
				.createParser("C:\\Users\\CSE\\Desktop\\New folder\\designpattern\\csvfile.scsv");
		Parser perser2 = new ParserFactory()
				.createParser("C:\\Users\\CSE\\Desktop\\New folder\\designpattern\\sjsonfile.sjson");

		assertEquals(perser.getClass(), ScsvParser.class);
		assertEquals(perser2.getClass(), SjsonParser.class);
	}

}
