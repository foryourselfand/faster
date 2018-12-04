using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskClicker : SpawnClicker
{
    public GrowDot StartDot;

    private GrowDot RemoveDot;

    void Start()
    {
        RemoveDot = Instantiate(StartDot, transform.position, Quaternion.identity);
    }

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        Destroy(RemoveDot);
    }
}