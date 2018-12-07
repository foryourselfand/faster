using UnityEngine;

public class ClassicDot : _GrowDot
{
    protected override void EndTrigger()
    {
        GetComponent<ClassicMaskDot>().OnDecrease();
    }
}