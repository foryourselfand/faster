using UnityEngine;

public class DecreaseLifeDot : AlwaysDot
{
    protected override void actionOnStart()
    {
        Debug.Log("Life Decreasing");
    }
}