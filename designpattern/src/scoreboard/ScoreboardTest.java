package scoreboard;


import static org.junit.Assert.*;

import org.junit.Test;
class ScoreboardTest {

	@Test
	void test01() {
		String actual = "Gryffindor vs Hufflepuff" + "\n== == ==\n" + "2 - 3" + "\n== == ==\n"
				+ "Player of the match: Newt of Hufflepuff";
		Scoreboard scoreboard = new Scoreboard(new Football());
		assertEquals(scoreboard.getscoreboard(), actual);
	}

	@Test
	void test02() {
		String actual = "Ravenclaw vs Slytherin\n" + "T20" + "\n== == ==\n" + "121/6 (16.1) - 122/7 (18.4)"
				+ "\n== == ==\n" + "Best Batter: Luna of Ravenclaw\n" + "Best Bowler: Regulus of Slytherin";
		Scoreboard scoreboard = new Scoreboard(new Cricket());
		assertEquals(scoreboard.getscoreboard(), actual);
	}

}
