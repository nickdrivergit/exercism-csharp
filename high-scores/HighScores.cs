using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scoresList; 
    public HighScores(List<int> list)
    {
        scoresList = list;
    }

    public List<int> Scores()
    {
        return scoresList;
    }

    public int Latest()
    {
        return scoresList[scoresList.Count - 1];
    }

    public int PersonalBest()
    {
        List<int> tmpList = scoresList;
        tmpList.Sort();
        return tmpList[scoresList.Count - 1];
    }

    public List<int> PersonalTopThree()
    {
        List<int> tmpList = scoresList;
        tmpList.Sort();
        tmpList.Reverse();
        if (tmpList.Count < 3)
            tmpList = tmpList.GetRange(0,tmpList.Count);
        else
            tmpList = tmpList.GetRange(0,3);
        return tmpList;
    }
}