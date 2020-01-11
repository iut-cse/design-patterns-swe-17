package lab1;

public class Football extends Game{
	
	String teamName;
	String score;
	String bestPlayer;
	
	public Football(String teamName, String score, String bestPlayer) {
		this.teamName = teamName;
		this.score = score;
		this.bestPlayer = bestPlayer;
	}

	@Override
	void teamInfo() {
		System.out.println(teamName);
		System.out.println("== == ==");
		
		
		
	}

	@Override
	void score() {
		System.out.println(score);
		System.out.println("== == ==");
		
	}

	@Override
	void bestPlayer() {
		System.out.println("Player of the match: "+bestPlayer);
		
	}

}
