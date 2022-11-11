namespace TestProject2;

[TestClass]
public class TennisTests
{
    private Tennis _tennis = new Tennis("Prochini","Ken");

    [TestMethod]
    public void Love_All()
    {
        ScoreSgouldBe("Love All");
    }
    [TestMethod]
    public void Fifteen_Love()
    {
        GivenFirstPlayerScoreTimes(1);
        ScoreSgouldBe("Fifteen Love");
    }

    [TestMethod]
    public void Thirty_Love()
    {
        GivenFirstPlayerScoreTimes(2);
        ScoreSgouldBe("Thirty Love");
    }
    
    [TestMethod]
    public void Forty_Love()
    {
        GivenFirstPlayerScoreTimes(3);
        ScoreSgouldBe("Forty Love");
    }
    
    [TestMethod]
    public void Forty_Fifteen()
    {
        GivenFirstPlayerScoreTimes(3);
        GivenSecondPlayerScoreTimes(1);
        ScoreSgouldBe("Forty Fifteen");
    }

    [TestMethod]
    public void Forty_Thirty()
    {
        GivenFirstPlayerScoreTimes(3);
        GivenSecondPlayerScoreTimes(2);
        ScoreSgouldBe("Forty Thirty");
    }

    [TestMethod]
    public void Love_Fifteen()
    {
        GivenSecondPlayerScoreTimes(1);
        ScoreSgouldBe("Love Fifteen");
    }
    
    [TestMethod]
    public void Love_Thirty()
    {
        GivenSecondPlayerScoreTimes(2);
        ScoreSgouldBe("Love Thirty");
    }


    [TestMethod]
    public void Fifteen_All()
    {
        GivenFirstPlayerScoreTimes(1);
        GivenSecondPlayerScoreTimes(1);
        ScoreSgouldBe("Fifteen All");
    }
    
    [TestMethod]
    public void Thirty_All()
    {
        GivenFirstPlayerScoreTimes(2);
        GivenSecondPlayerScoreTimes(2);
        ScoreSgouldBe("Thirty All");
    }
    
    [TestMethod]
    public void Deuce()
    {
        GivenDeuce();
        ScoreSgouldBe("Deuce");
    }

    [TestMethod]
    public void FirstPlayer_Adv()
    {
        GivenDeuce();
        GivenFirstPlayerScoreTimes(1);
        ScoreSgouldBe("Prochini Adv");
    }
    
    [TestMethod]
    public void SecondPlayer_Adv()
    {
        GivenDeuce();
        GivenSecondPlayerScoreTimes(1);
        ScoreSgouldBe("Ken Adv");
    }
    
    [TestMethod]
    public void SecondPlayer_Win()
    {
        GivenDeuce();
        GivenSecondPlayerScoreTimes(2);
        ScoreSgouldBe("Ken Win");
    }
    
    private void GivenDeuce()
    {
        GivenFirstPlayerScoreTimes(3);
        GivenSecondPlayerScoreTimes(3);
    }


    private void GivenSecondPlayerScoreTimes(int times)
    {
        for (int i = 0; i < times; i++)
        {
            _tennis.SecondPlayerScore();
        }
    }

    
    private void GivenFirstPlayerScoreTimes(int times)
    {
        for (int i = 0; i < times; i++)
        {
            _tennis.FirstPlayerScore();
        }

    }

    private void ScoreSgouldBe(string expected)
    {
        Assert.AreEqual(expected, _tennis.Score());
    }
}
 