package scoreboard;

public class Scoreboard {

	Sports sport;
	String devider = "\n== == ==\n";

	public Scoreboard(Sports sport) {
		this.sport = sport;
	}

	String getscoreboard() {
		return sport.getteaminfo() + devider + sport.getscore() + devider + sport.gettopplayer();
	}
	
	public static void main(String[] args) {
		Scoreboard s = new Scoreboard(new Cricket());
		System.out.println(s.getscoreboard());
	}
}
