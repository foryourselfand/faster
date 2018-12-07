using UnityEngine;

public class _MaskDot : _DotSpawner
{
    public void OnClicked()
    {
        Spawn(dotToSpawn);
    }

    public void Spawn(_GrowDot dot)
    {
        SpawnDot(dot);
        child.transform.parent = transform.parent.parent;
        Destroy(transform.parent.gameObject);
    }
}