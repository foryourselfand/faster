using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridClicker : _SpawnClicker
{
    [HideInInspector] public bool isFree = true;

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        isFree = false;
        child.transform.parent = gameObject.transform;
    }
}