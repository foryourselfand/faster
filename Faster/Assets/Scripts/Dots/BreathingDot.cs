using UnityEditor;
using UnityEngine;

public class BreathingDot : _ChangeSpeedDot
{
    public Vector3 anotherSecondScale;

    protected override void fromSecondToFirst()
    {
        count += 2;
        firstScale = anotherSecondScale;
        base.fromSecondToFirst();
    }
}