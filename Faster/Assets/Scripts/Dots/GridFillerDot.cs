using UnityEngine;

public class GridFillerDot : _GrowDot
{
    protected override void EndTrigger()
    {
        gameObject.transform.root.GetComponentInChildren<GridClicker>().isFree = true;
        Destroy(gameObject);
    }
}