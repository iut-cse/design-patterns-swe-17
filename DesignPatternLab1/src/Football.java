public class Football extends Sports{
    String  teamA;
    String  teamB;
    String bestPlayer;
    String bestplayerTeam;
    int scoreA;
    int scoreB;

    public Football(String teamA, String teamB, int scoreA, int scoreB){
        this.teamA = teamA;
        this.teamB = teamB;
        this.scoreA = scoreA;
        this.scoreB = scoreB;
    }
    @Override
    public String getTeamname() {
        return teamA + " vs " + teamB;
    }

    @Override
    public String getScore() {
        return scoreA + " - " + scoreB;
    }

    @Override
    public String getBestPlayer() {
        return "Player of the match: " + bestPlayer +" of "+ bestplayerTeam;
    }
}

