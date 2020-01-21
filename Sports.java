public abstract class Sports {

    abstract String getTeamname();
    abstract String getScore();
    abstract String getBestPlayer();



    public String Implement_ScoreBoard ()
    {
        String Teams = getTeamname();
        String Score = getScore();
        String Best_Player = getBestPlayer();
        return Teams + "\n" + "== == ==" + "\n" + Score + "\n" + "== == ==" + "\n" + Best_Player;
    }

}
