using UnityEngine;

public class GrowClassicButton : GrowButton
{
    public override void fromUpToDown()
    {
        target = down;
    }

    public override void fromDownToUp()
    {
    }
}