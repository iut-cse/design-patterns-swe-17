package scoreboard;

public class Cricket extends Sports {
	
	String teaminfo = "Ravenclaw vs Slytherin\n" + "T20";
	String teamscore = "121/6 (16.1) - 122/7 (18.4)";
	String topplayer = "Best Batter: Luna of Ravenclaw\n" + "Best Bowler: Regulus of Slytherin";

	@Override
	String getteaminfo() {
		// TODO Auto-generated method stub
		return teaminfo;
	}

	@Override
	String getscore() {
		// TODO Auto-generated method stub
		return teamscore;
	}

	@Override
	String gettopplayer() {
		// TODO Auto-generated method stub
		return topplayer;
	}

}
