using UnityEngine;
using UnityEngine.UI;

public class IncreaseScoreDot : GridFillerDot
{
    protected override void actionOnStart()
    {
        _GameMode.currentScore += 1;
        GameObject.Find("ScoreText").GetComponent<Text>().text = _GameMode.currentScore.ToString();
    }
}