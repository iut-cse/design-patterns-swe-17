package unknown;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class TestClass {

	String[] title = { "Department", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",
			"Total" };

	@Test
	void titletest() {
		ReportGenarator testclass = new ReportGenarator("dataset.csv", title);
		System.out.println(testclass.gettitle());
	}

	@Test
	void alldatatest() {
		ReportGenarator testclass = new ReportGenarator("dataset.csv", title);
		System.out.println(testclass.getalldata());
	}

	@Test
	void totaltest() {
		ReportGenarator testclass = new ReportGenarator("dataset.csv", title);
		System.out.println(testclass.gettotal());
	}

	@Test
	void singledatatest() {
		ReportGenarator testclass = new ReportGenarator("dataset.csv", title);
		System.out.println(testclass.getdata("Phy"));
	}

	@Test
	void allinonetest() {
		ReportGenarator testclass = new ReportGenarator("dataset.csv", title);
		System.out.println(testclass.gettitle());
		System.out.println(testclass.getalldata());
		System.out.println(testclass.gettotal());
	}

	@Test
	void allinonetest02() {
		ReportGenarator testclass = new ReportGenarator("datasettest.csv", title);
		System.out.println(testclass.gettitle());
		System.out.println(testclass.getalldata());
		System.out.println(testclass.gettotal());
	}

}
