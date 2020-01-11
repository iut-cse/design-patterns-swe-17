package lab1;

public class Cricket extends Game{
	
	String teamName;
	String gametype;
	String score;
	String bestBatter;
	String bestBowler;
	
	public Cricket(String teamName, String gameType,String score, String bestBatter, String bestBowler) {
		this.teamName = teamName;
		this.gametype = gameType;
		this.score = score;
		this.bestBatter = bestBatter;
		this.bestBowler = bestBowler;
		
	}

	@Override
	void teamInfo() {
		System.out.println(teamName);
		System.out.println(gametype);
		System.out.println("== == ==");
		
	}

	@Override
	void score() {
		System.out.println(score);
		System.out.println("== == ==");
		
	}

	@Override
	void bestPlayer() {
		System.out.println("Best Batter: "+bestBatter);
		System.out.println("Best Bowler: "+bestBowler);
		
	}

}
