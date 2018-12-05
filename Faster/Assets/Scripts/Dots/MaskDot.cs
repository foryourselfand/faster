using UnityEngine;

public class MaskDot : _DotSpawner
{
    public void OnClicked()
    {
        SpawnDot();
        child.transform.parent = transform.parent.parent;
        Destroy(transform.parent.gameObject);
    }
}