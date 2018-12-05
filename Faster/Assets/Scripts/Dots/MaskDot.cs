public class MaskDot : _SpawnClicker
{
    public void OnClicked()
    {
        OnMouseDown();
        Destroy(gameObject);
    }
}