public class Cricket extends Sports{
    String gametype;
    String  teamA;
    String  teamB;
    String bestBatsman;
    String bestBatsmanteam;
    String bestBowlerteam;
    String bestBowler;
    int scoreA;
    int scoreB;

    public Cricket(String teamA, String teamB, int scoreA, int scoreB){
        this.teamA = teamA;
        this.teamB = teamB;
        this.scoreA = scoreA;
        this.scoreB = scoreB;
    }
    @Override
    public String getTeamname() {
        return teamA + " vs " + teamB + "\n" + gametype;
    }

    @Override
    public String getScore() {
        return scoreA + " - " + scoreB;
    }

    @Override
    public String getBestPlayer() {
        return "Player Batter: " + bestBatsman +" of "+ bestBatsmanteam + "\n" + "Player Bowler: " + bestBowler +" of "+ bestBowlerteam;
    }
}
