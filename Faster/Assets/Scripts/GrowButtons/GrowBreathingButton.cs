public class GrowBreathingButton : GrowButton
{
    public void fromUpToDown()
    {
        base.fromUpToDown();
        target = down;
    }

    public void fromDownToUp()
    {
        target = up;
    }
}