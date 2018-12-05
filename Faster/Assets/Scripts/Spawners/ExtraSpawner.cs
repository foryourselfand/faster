using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpawner : _GameSpawner
{
    protected override void Start()
    {
        base.Start();
    }
    
    protected override void SpawnNewWave()
    {
        Debug.Log("Extra New Wave");
    }
}