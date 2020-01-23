package unknown;

import java.util.Dictionary;
import java.util.Enumeration;
import java.util.Hashtable;

public class DataManager {

	Dictionary<String, Dataframe> data = new Hashtable<String, Dataframe>();
	int[] totalhour = new int[7];
	int total2 = 0;
	int[] space;
	String[] title;
	String titletotal = "Total";
	String divider = " | ";

	public DataManager(String[] title) {
		for (int i = 0; i < 7; i++) {
			totalhour[i] = 0;
		}
		space = new int[title.length];
		for (int i = 0; i < title.length; i++) {
			space[i] = title[i].length();
		}
		space[0] = Math.max(space[0], titletotal.length());
		this.title = title;
	}

	public void setdata(String dept, int day, int hours) {
		if (data.get(dept) != null) {
			data.get(dept).setHour(day, hours);
		} else {
			space[0] = Math.max(space[0], dept.length());
			data.put(dept, new Dataframe(dept));
			data.get(dept).setHour(day, hours);
		}
		totalhour[day] += hours;
		total2 += hours;

		space[day + 1] = Math.max(space[day + 1], Integer.toString(totalhour[day]).length());
		space[space.length - 1] = Math.max(space[space.length - 1], Integer.toString(total2).length());

	}

	String alignleft(String data, int space) {
		return String.format("%1$" + space + "s", data);
	}

	String alignright(String data, int space) {
		return String.format("%1$-" + space + "s", data);
	}

	String getdata(String dept) {
		String n = "";
		n = data.get(dept).getDepartment();
		n = alignright(n, space[0]);
		n += divider;
		for (int i = 0; i < 7; i++) {
			n += alignleft(Integer.toString(data.get(dept).getHour(i)), space[i + 1]);
			n += divider;
		}
		n += alignleft(Integer.toString(data.get(dept).getTotal()), space[space.length - 1]);
		return n;
	}

	String getalldata() {
		String temp = "";
		for (Enumeration i = data.keys(); i.hasMoreElements();) {
			temp = temp + getdata(i.nextElement().toString()) + "\n";
		}
		return temp.trim();
	}

	String gettitle() {
		String title = alignright(this.title[0], space[0]);
		for (int i = 1; i < this.title.length; i++) {
			title = title + divider + alignleft(this.title[i], space[i]);
		}
		return title;
	}

	String gettotal() {
		String t = alignright(titletotal, space[0]);
		for (int i = 0; i < 7; i++) {
			t = t + divider + alignleft(Integer.toString(totalhour[i]), space[i + 1]);
		}
		return t + divider + alignleft(Integer.toString(total2), space[space.length - 1]);
	}

}
