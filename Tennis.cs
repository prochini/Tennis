namespace TestProject2;

public class Tennis
{
    private readonly string _firstPlayerName;
    private readonly string _secondPlayerName;
    private int _firstPlayerScore;

    private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
    {
        { 0, "Love" },
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" }
    };

    private int _secondPlayerScore;

    public Tennis(string firstPlayerName, string secondPlayerName)
    {
        _firstPlayerName = firstPlayerName;
        _secondPlayerName = secondPlayerName;
    }

    public string Score()
    {
        if (IsScoreDiffrence())
        {
            return IsReadyForGamePoint() ? AdvState() : LookUpScore();
        }

        
        return IsDeuce() ? "Deuce" : SameScore();
    }

    private string AdvState()
    {
        return IsAdv() ? $"{AdvPlayer()} Adv" : $"{AdvPlayer()} Win";
    }

    private bool IsReadyForGamePoint()
    {
        return _firstPlayerScore>3 || _secondPlayerScore>3;
    }

    private bool IsAdv()
    {
        return Math.Abs(_firstPlayerScore-_secondPlayerScore)==1;
    }

    private string AdvPlayer()
    {
        var advPlayer = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
        return advPlayer;
    }

    private bool IsScoreDiffrence()
    {
        return _firstPlayerScore != _secondPlayerScore;
    }

    private string LookUpScore()
    {
        return $"{_scoreLookUp[_firstPlayerScore]} {_scoreLookUp[_secondPlayerScore]}";
    }

    private string SameScore()
    {
        return $"{_scoreLookUp[_firstPlayerScore]} All";
    }

    private bool IsDeuce()
    {
        return _firstPlayerScore >= 3;
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScore++;
    }

    public void SecondPlayerScore()
    {
        _secondPlayerScore++;
    }
}