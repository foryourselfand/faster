using UnityEditor;
using UnityEngine;

public class BreathingDot : GrowDot
{
    public Vector3 anotherSecondScale;
    public float secondSpeed;

    protected override void fromSecondToFirst()
    {
        speed = secondSpeed;
        count += 2;
        firstScale = anotherSecondScale;
        target = firstScale;
    }
}