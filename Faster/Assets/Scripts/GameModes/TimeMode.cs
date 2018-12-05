using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMode : _GameMode
{
    protected override void Start()
    {
        base.Start();
    }

    public override void SpawnNewWave()
    {
        Debug.Log("Time New Wave");
    }
}