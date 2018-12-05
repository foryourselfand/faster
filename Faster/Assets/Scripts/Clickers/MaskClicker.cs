using UnityEngine;

public class MaskClicker : _DotSpawner
{
    private void Start()
    {
        SpawnDot();
    }

    private void OnMouseDown()
    {
        GetComponentInChildren<MaskDot>().OnClicked();
    }
}