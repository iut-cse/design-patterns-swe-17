package fileparser;

public class ParserFactory {

	public Parser createParser(String filepath) {
		Parser parser;
		if (filepath.endsWith(".scsv")) {
			parser = new ScsvParser(filepath);
		} else if (filepath.endsWith(".sjson")) {
			parser = new SjsonParser(filepath);
		} else {
			parser = null;
		}
		return parser;
	}
}
