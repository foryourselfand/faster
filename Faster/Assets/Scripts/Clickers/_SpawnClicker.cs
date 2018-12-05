using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpawnClicker : MonoBehaviour
{
    public _GrowDot clickedDot;

    protected virtual void OnMouseDown()
    {
        Instantiate(clickedDot, transform.position, Quaternion.identity);
    }
}