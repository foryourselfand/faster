using UnityEngine;

public class BreathingDot : GrowDot
{
    public Vector3 anotherSecondScale;

    protected override void fromSecondToFirst()
    {
        count += 2;
        firstScale = anotherSecondScale;
        target = firstScale;
    }
}