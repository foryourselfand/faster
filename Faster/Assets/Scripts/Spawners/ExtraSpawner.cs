using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpawner : GameSpawner
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Extra");
    }
}