using System.Collections;
using System.Collections.Generic;

public static class Score
{
    private static int _score;
    public static int score { get { return _score; } }
    public static void ScoreIncrement()
    {
        _score++;
    }
    public static void ScoreSave()
    {

    }
    public static void ScoreLoad()
    {

    }
}
