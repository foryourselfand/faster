using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMode : _GameMode
{
    private int timeCount;
    
    public override void SpawnNewWave()
    {
        Debug.Log("Time New Wave");
    }

    public override void ChangeIfAddition()
    {
        timeCount = 30;
        if (Addition)
            timeCount += 10;

        decreasingType.GetComponent<Text>().text = string.Format("0:{0:0}", timeCount);
    }
}