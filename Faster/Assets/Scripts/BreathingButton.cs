using UnityEngine;

public class BreathingButton : GrowButton
{
    public Vector3 anotherSecond;

    protected override void fromSecondToFirst()
    {
        count += 2;
        firstScale = anotherSecond;
        target = firstScale;
    }
}