using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : _GameSpawner
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void SpawnNewWave()
    {
        Debug.Log("Time New Wave");
    }
}