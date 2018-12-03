using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    public GameObject activeButton;
    private GameObject destroyObject;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        destroyObject = (GameObject) Instantiate(activeButton, transform.position, Quaternion.identity);
    }

    void OnMouseUp()
    {
        DestroyObject(destroyObject);
    }
}