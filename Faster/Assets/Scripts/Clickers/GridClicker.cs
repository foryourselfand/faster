using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridClicker : SpawnClicker
{
    [HideInInspector] public bool IsFree = true;

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        IsFree = false;
    }
}