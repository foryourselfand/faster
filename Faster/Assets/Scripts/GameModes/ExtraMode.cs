﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraMode : _GameMode
{
    protected override void Start()
    {
        base.Start();
    }

    public override void SpawnNewWave()
    {
        Debug.Log("Extra New Wave");
    }
}