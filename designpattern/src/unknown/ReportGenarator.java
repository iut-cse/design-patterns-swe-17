package unknown;

import java.util.Date;

import fileparser.ScsvParser;

public class ReportGenarator {
	String filename;
	DataManager dm;
	int[] fixdate = { 2, 3, 4, 5, 6, 0, 1 };

	public ReportGenarator(String filename, String[] title) {
		this.filename = filename;
		dm = new DataManager(title);
		loaddata();
	}

	void loaddata() {
		ScsvParser csvparser = new ScsvParser(filename);
		int totaldata = csvparser.getitemcount();
		int day;
		String department, hour;
		for (int i = 0; i < totaldata; i++) {
			String[] temp = csvparser.getdata(i).split(",");
			department = temp[0];
			hour = temp[2];
			String[] datestring = temp[1].split("-");

			Date date = new Date(Integer.parseInt(datestring[0]), Integer.parseInt(datestring[1]), Integer.parseInt(datestring[2]));
			day = fixdate[date.getDay()];
			dm.setdata(department, day, Integer.parseInt(hour));
		}
	}

	String gettitle() {
		return dm.gettitle();
	}

	String getalldata() {
		return dm.getalldata();
	}

	String gettotal() {
		return dm.gettotal();
	}

	String getdata(String dept) {
		return dm.getdata(dept);
	}

}
