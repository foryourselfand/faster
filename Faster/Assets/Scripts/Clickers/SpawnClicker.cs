using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClicker : MonoBehaviour
{
    public GrowDot ClickedDot;

    protected virtual void OnMouseDown()
    {
        Instantiate(ClickedDot, transform.position, Quaternion.identity);
    }
}