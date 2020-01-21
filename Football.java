public class Football extends Sports {
    String team_A;
    String team_B;
    String score_team_A;
    String score_team_B;
    String best_Player;
    String best_Player_team;

    public Football(String team_A,String team_B, String score_team_A,String score_team_B, String best_Player,String best_Player_team)
    {
        this.team_A = team_A;
        this.team_B = team_B;
        this.score_team_A = score_team_A;
        this.score_team_B = score_team_B;
        this.best_Player = best_Player;
        this.best_Player_team = best_Player_team;
    }

    public String getTeamname()
    {
        return team_A + "vs" + team_B;
    }
    public String getScore()
    {
        return score_team_A + "-" + score_team_B;
    }
    public String getBestPlayer()
    {
        return best_Player + "of" + best_Player_team;
    }
}
