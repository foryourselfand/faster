using UnityEngine;

public class ClassicDot : _GrowDot
{
    protected override void actionOnEnd()
    {
        GetComponent<ClassicMaskDot>().OnDecrease();
    }
}