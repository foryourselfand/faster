using UnityEngine;

public class GrowClassicButton : GrowButton
{
    public void fromUpToDown()
    {
        base.fromUpToDown();
        target = down;
    }
}