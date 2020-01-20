public class Main {
    public static void main(String [] args)
    {
        String[] TopPlayer = {"Newt of Hufflepuff"};
        String[] TopPlayer2 = {"Best Batter: Luna of Ravenclaw ","Best Bowler: Regulus of Slytherin"};
        DisplayScore displayScore1 = new DisplayScore(Game.FOOTBALL,"Gryffindor","Hufflepuff", "2","3",TopPlayer,null);
        displayScore1.ScoreDisplay();
        DisplayScore displayScore2 = new DisplayScore(Game.CRICKET,"Ravenclaw","Slytherin","121/6 (16.1)","122/7 (18.4)",TopPlayer2,"T20");
        displayScore2.ScoreDisplay();
    }
}
