using UnityEngine;

public class AlwaysDot : _GrowDot
{
    protected override void ChangeScale()
    {
        transform.localScale =
            Vector3.MoveTowards(transform.localScale, target, Time.deltaTime * speed);
    }
}