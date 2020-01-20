import java.util.List;

public class DisplayScore {

    private IScoreBoard gameScore;
    private String teamA, teamB , ScoreA, ScoreB , Matchtype;
    private String[] PlayerName;

    public DisplayScore(Game _gameType, String teamA, String teamB, String ScoreA, String ScoreB, String[] PlayerName , String matchtype)
    {
        this.gameScore = CreateGame(_gameType);
        this.teamA = teamA ;
        this.teamB = teamB ;
        this. ScoreA = ScoreA ;
        this.ScoreB = ScoreB ;
        this.PlayerName = PlayerName;
        this.Matchtype = matchtype;
    }

    public IScoreBoard CreateGame(Game gametype)
    {

        if(gametype == Game.FOOTBALL)
        {
            gameScore = new Football();
            return gameScore;
        }
        else if (gametype == Game.CRICKET)
        {
            gameScore = new Cricket(Matchtype);
            return gameScore;
        }
        else
            return gameScore=null;
    }

    public void ScoreDisplay()
    {
        gameScore.Teaminfo(teamA , teamB);
        gameScore.TeamScore(ScoreA, ScoreB);
        gameScore.TopPlayers(PlayerName);
    }
}
