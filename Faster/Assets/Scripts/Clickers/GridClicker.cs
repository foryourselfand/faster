using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridClicker : _DotSpawner
{
    [HideInInspector] public bool isFree = true;

    void OnMouseDown()
    {
        SpawnDot();
        isFree = false;
    }
}