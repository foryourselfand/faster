using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicSpawner : _GameSpawner
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void SpawnNewWave()
    {
        Debug.Log("Classic New Wave");
    }
}