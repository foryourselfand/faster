using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraMode : ClassicMode
{
    public GameObject extraDot;

    protected override void ActionInCoroutine()
    {
        if (Random.Range(0, 4) == 0)
            SpawnNewDot(extraDot);
        else
            SpawnNewDot(dotToSpawn);
        DecreaseSeconds();
    }
 
}