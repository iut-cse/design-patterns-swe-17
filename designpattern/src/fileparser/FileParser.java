package fileparser;

public class FileParser {

	public Parser getparser(String filepath) {
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
