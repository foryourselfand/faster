using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : GameSpawner
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Time");
    }
}