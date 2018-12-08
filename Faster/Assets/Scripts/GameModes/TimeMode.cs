using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMode : _GameMode
{
    private int timeCount;
    private Text timeText;
    private int currentCount;
    private int minCount;

    protected override void Start()
    {
        base.Start();
        timeText = decreasingType.GetComponent<Text>();
    }

    public override void ChangeIfAddition()
    {
        timeCount = 30;
        if (Addition)
            timeCount += 10;
        SetTimeTo(timeCount);
    }

    public override void ResetValues()
    {
        minCount = Random.Range(0, 3) + 2;
        for (int i = 0; i < 4; i++)
            SpawnNewDot(dotToSpawn);
        currentCount = 5;
        CheckForNewWave();
    }

    protected override void ActionInCoroutine()
    {
        timeCount--;
        SetTimeTo(timeCount);
    }

    public void CheckForNewWave()
    {
        currentCount--;
        if (currentCount <= minCount)
        {
            var temp = Random.Range(0, 3) + 2;
            currentCount += temp;
            for (int i = 0; i < temp; i++)
                SpawnNewDot(dotToSpawn);
            minCount = temp;
        }

//        Debug.Log(string.Format("{0}\t{1}", currentCount, minCount));
    }

    private void SetTimeTo(int count)
    {
        timeText.text = string.Format("0:{0:00}", count);
    }
}