using UnityEngine;

public class _MenuButton : MonoBehaviour
{
    public GameObject activeButton;
    private GameObject destroyObject;

    protected void OnMouseDown()
    {
        destroyObject = Instantiate(activeButton, transform.position, Quaternion.identity);
    }

    protected virtual void OnMouseUp()
    {
        Destroy(destroyObject);
    }
}