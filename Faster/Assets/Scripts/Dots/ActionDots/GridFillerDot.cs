using UnityEngine;

public class GridFillerDot : _GrowDot
{
    protected override void actionOnEnd()
    {
        GetComponentInParent<GridClicker>().isFree = true;
        Destroy(gameObject);
    }
}