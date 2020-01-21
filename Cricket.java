public class Cricket extends Sports {
    String score_team_A;
    String score_team_B;
    String match_type;
    String  team_A;
    String  team_B;
    String best_Batter;
    String best_Batter_team;
    String best_Bowler;
    String best_Bowler_team;

    public Cricket(String team_A,String team_B,String score_team_A,String score_team_B,String match_type,String best_Batter,String best_Bowler,String best_Batter_team,String best_Bowler_team)
    {
        this.match_type = match_type;
        this.team_A = team_A;
        this.team_B = team_B;
        this.score_team_A = score_team_A;
        this.score_team_B = score_team_B;
        this.best_Batter = best_Batter;
        this.best_Batter_team = best_Batter_team;
        this.best_Bowler = best_Bowler;
        this.best_Bowler_team = best_Bowler_team;
    }

    public String getTeamname()
    {
        return team_A + "vs" + team_B + "\n" + match_type;
    }
    public String getScore()
    {
        return score_team_A + "-" + score_team_B;
    }
    public String getBestPlayer()
    {
        return "Best Batter : " + best_Batter + "of" + best_Batter_team + "\n" + "Best Bowler : " + best_Bowler + "of" + best_Bowler_team;
    }
}
