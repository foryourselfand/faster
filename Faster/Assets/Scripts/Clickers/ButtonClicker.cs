﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    public GameObject activeButton;
    private GameObject destroyObject;

    protected virtual void OnMouseDown()
    {
        destroyObject = (GameObject) Instantiate(activeButton, transform.position, Quaternion.identity);
    }

    protected virtual void OnMouseUp()
    {
        Destroy(destroyObject);
    }
}