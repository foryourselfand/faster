using UnityEngine;

public class MaskClicker : _DotSpawner
{
    private void Start()
    {
        SpawnDot();
    }

    protected virtual void OnMouseDown()
    {
        GetComponentInChildren<_MaskDot>().OnClicked();
    }
}