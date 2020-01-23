package fileparser;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class ScsvParser extends Parser {
	File file;

	public ScsvParser(String filepath) {
		file = new File(filepath);

	}

	@Override
	public String getdata(int index) {
		String data = null;
		int count = -1;
		Scanner sc;
		try {
			sc = new Scanner(file);
			while (sc.hasNextLine()) {
				if (count == index) {
					data = sc.nextLine();
				} else {
					String temp = sc.nextLine();
				}

				count++;
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}

		return data;
	}

	@Override
	public int getitemcount() {
		int count = -1;
		try {
			Scanner sc = new Scanner(file);
			while (sc.hasNextLine()) {
				String temp = sc.nextLine();
				count++;
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}

		return count;
	}
}
