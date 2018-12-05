using UnityEngine;

public class MaskClicker : MonoBehaviour
{
    public GameObject dot;

    private void Start()
    {
        var temp = Instantiate(dot, transform.position, Quaternion.identity);
        temp.transform.parent = gameObject.transform;
    }

    private void OnMouseDown()
    {
        GetComponentInChildren<MaskDot>().OnClicked();
    }
}