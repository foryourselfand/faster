using UnityEngine;

public class ClassicDot : _ChangeSpeedDot
{
    protected override void actionOnEnd()
    {
        GetComponent<ClassicMaskDot>().OnDecrease();
    }
}