using UnityEngine;

public class NotStarted : AlwaysDot
{
    public void GoDownOnce()
    {
        secondScale = Vector3.zero;
        target = secondScale;
        count = 1;
    }

    public void LastChange()
    {
        count = 7;
    }
}