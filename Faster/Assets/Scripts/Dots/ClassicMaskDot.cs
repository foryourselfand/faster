public class ClassicMaskDot : MaskDot
{
    public _GrowDot dotOnDecrease;

    public void OnDecrease()
    {
        Spawn(dotOnDecrease);
    }
}