package fileparser;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class ScsvParser extends Parser {
	File file;

	public ScsvParser(String filepath) {
		// TODO Auto-generated constructor stub
		file = new File(filepath);
		
	}

	@Override
	String getdata(int index) {
		// TODO Auto-generated method stub
		String data = null;
		int count = -1;
		Scanner sc;
		try {
			sc = new Scanner(file);
			 while (sc.hasNextLine()) {
				 if(count==index) {
					 data = sc.next();
				 }
				 
				 count ++;
			 }
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
		
		return data;
	}

	@Override
	int getitemcount() {
		// TODO Auto-generated method stub
		return 3;
	}
}
