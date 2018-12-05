using UnityEngine;

public class GridFillerDot : _GrowDot
{
    protected override void EndTrigger()
    {
        GetComponentInParent<GridClicker>().isFree = true;
        Destroy(gameObject);
    }
}