using UnityEngine;

public class AlwaysDot : GridFillerDot
{
    protected override void ChangeScale()
    {
        transform.localScale =
            Vector3.MoveTowards(transform.localScale, target, Time.deltaTime * speed);
    }
}