using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicSpawner : GameSpawner
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Classic");
    }
}