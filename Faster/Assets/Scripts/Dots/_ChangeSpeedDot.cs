public class _ChangeSpeedDot : _GrowDot
{
    public float secondSpeed;

    protected override void changeSpeed()
    {
        speed = secondSpeed;
    }
}