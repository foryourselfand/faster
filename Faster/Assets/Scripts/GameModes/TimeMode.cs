using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMode : _GameMode
{
    private int timeCount;
    private Text timeText;

    protected override void Start()
    {
        base.Start();
        timeText = decreasingType.GetComponent<Text>();
    }

    public override void SpawnStartWave()
    {
        Debug.Log("Time New Wave");
        StartCoroutine(DecreaseTimeScore());
        
    }

    IEnumerator DecreaseTimeScore()
    {
        while (true)
        {
            timeCount--;
            SetTimeTo(timeCount);
            yield return new WaitForSeconds(1);
        }
    }

    public override void ChangeIfAddition()
    {
        timeCount = 30;
        if (Addition)
            timeCount += 10;
        SetTimeTo(timeCount);
    }

    private void SetTimeTo(int count)
    {
        timeText.text = string.Format("0:{0:0}", count);
    }
}