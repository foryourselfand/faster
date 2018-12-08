using UnityEngine;

public class CheckTimeDot : IncreaseScoreDot
{
    protected override void actionOnStart()
    {
        base.actionOnStart();
        GameObject.Find("TimeMode").GetComponent<TimeMode>().CheckForNewWave();
    }
}