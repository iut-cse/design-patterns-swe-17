public class Football extends Scoreboard {
    String team1, team2;
    public Football(String team1, String team2){
        this.team1=team1;
        this.team2=team2;
    }
    @Override
    public String teamNmae() {
        return team1+" VS " +team2;
    }

    @Override
    public String score() {
        return null;
    }
}
