package fileparser;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class SjsonParser extends Parser {

	File file;

	public SjsonParser(String filepath) {
		file = new File(filepath);
	}

	@Override
	String getdata(int index) {
		String data = "";
		int count = 0;
		Scanner sc;
		try {
			sc = new Scanner(file);
			while (sc.hasNextLine()) {
				if (count == index) {
					while (sc.hasNextLine()) {
						String temp = sc.nextLine();
						if (temp.equals("=")) {
							count++;
							break;
						}
						if (data.equals("")) {
							data = data
									+ temp.substring(temp.indexOf(": ") + 2);
						} else {
							data = data + ","
									+ temp.substring(temp.indexOf(": ") + 2);
						}
					}
				} else {
					while (sc.hasNextLine()) {
						String temp = sc.nextLine();
						if (temp.equals("=")) {
							count++;
							break;
						}
					}
				}
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		System.out.println(data);
		return data;
	}

	@Override
	int getitemcount() {
		int count = 1;
		try {
			Scanner sc = new Scanner(file);
			if (!sc.hasNextLine()) {
				count--;
				return count;
			}
			while (sc.hasNextLine()) {
				String temp = sc.nextLine();
				if (temp.equals("=")) {
					count++;
				}
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}

		return count;
	}
}
