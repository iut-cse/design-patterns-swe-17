package scoreboard;

public class Football extends Sports {
	
	String teaminfo = "Gryffindor vs Hufflepuff";
	String teamscore = "2 - 3";
	String topplayer = "Player of the match: Newt of Hufflepuff";

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
