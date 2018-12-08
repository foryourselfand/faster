using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicMode : _GameMode
{
    private int heartCount;

    public override void ChangeIfAddition()
    {
        heartCount = 3;
        decreasingType.transform.GetChild(3).gameObject.SetActive(Addition);
        decreasingType.transform.GetChild(4).gameObject.SetActive(Addition);
        if (!Addition)
        {
            decreasingType.transform.position = new Vector3(0f, 0, 0);
        }
        else
        {
            heartCount += 2;
            decreasingType.transform.position = new Vector3(-0.5f, 0, 0);
        }
    }

    public override void ResetValues()
    {
        currentScore = 0;
        secTillNext = 0.8f;
    }


    protected override void ActionInCoroutine()
    {
        SpawnNewDot(dotToSpawn);
        DecreaseSeconds();
    }

    protected void DecreaseSeconds()
    {
        //TODO Level by level decreasing
        if (secTillNext >= 0.4f)
            secTillNext -= 0.05f;
    }
}