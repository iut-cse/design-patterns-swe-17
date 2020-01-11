package lab1;

import java.util.Scanner;

public class ShowScore {
	
	public static void main(String [] args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Enter type of game: 1.Football 2.Cricket");
		int number = input.nextInt();
				
		
		if(number ==1) {
			Football ft = new Football("Gryffindor vs Hufflepuff","2 - 3","Newt of Hufflepuff");
			ft.teamInfo();
			ft.score();
			ft.bestPlayer();
		}
		else if(number == 2){
			Cricket ct = new Cricket("Ravenclaw vs Slytherin","T20","121/6 (16.1) - 122/7 (18.4)","Luna of Ravenclaw","Regulus of Slytherin");
			ct.teamInfo();
			ct.score();
			ct.bestPlayer();
		}
		
	
		
	}

}
