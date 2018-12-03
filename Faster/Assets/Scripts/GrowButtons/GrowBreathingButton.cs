using UnityEngine;

public class GrowBreathingButton : GrowButton
{
    public override void fromUpToDown()
    {
        target = down;
    }

    public override void fromDownToUp()
    {
        target = up;
    }
}