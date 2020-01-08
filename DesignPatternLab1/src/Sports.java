public abstract class Sports implements Sports_interface {


    @Override
    public void showscoreboard() {
        System.out.println(getTeamname() + "\n" + getScore() + "\n" + getBestPlayer() + "\n" );
    }
}
