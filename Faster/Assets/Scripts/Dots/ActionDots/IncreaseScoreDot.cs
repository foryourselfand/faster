using UnityEngine;
using UnityEngine.UI;

public class IncreaseScoreDot : GridFillerDot
{
    protected override void actionOnStart()
    {
        ClassicMode.score += 1;
        GameObject.Find("ScoreText").GetComponent<Text>().text = ClassicMode.score.ToString();
    }
}