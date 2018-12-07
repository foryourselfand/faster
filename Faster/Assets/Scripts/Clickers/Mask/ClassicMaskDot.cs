public class ClassicMaskDot : _MaskDot
{
    public _GrowDot dotOnDecrease;

    public void OnDecrease()
    {
        Spawn(dotOnDecrease);
    }
}