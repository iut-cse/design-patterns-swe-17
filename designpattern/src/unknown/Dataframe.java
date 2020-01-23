package unknown;

public class Dataframe {

	String department;
	int[] hour = new int[7];
	int total = 0;

	public Dataframe(String department) {
		this.department = department;
		for (int i = 0; i < 7; i++) {
			hour[i] = 0;
		}
	}

	public void setDepartment(String department) {
		this.department = department;
	}

	public String getDepartment() {
		return department;
	}

	public void setHour(int day, int hour) {
		this.hour[day] += hour;
		total += hour;
	}

	public int getHour(int day) {
		return this.hour[day];
	}

	public int getTotal() {
		return total;
	}

	@Override
	public String toString() {
		String alldata = department;
		for (int i = 0; i < hour.length; i++) {
			alldata = alldata + "," + hour[i];
		}
		alldata = alldata + "," + total;
		return alldata;
	}

}
