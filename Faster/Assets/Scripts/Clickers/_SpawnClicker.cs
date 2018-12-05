using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpawnClicker : MonoBehaviour
{
    public _GrowDot clickedDot;
    protected _GrowDot child;

    protected virtual void OnMouseDown()
    {
        child = Instantiate(clickedDot, transform.position, Quaternion.identity);
        child.transform.parent = gameObject.transform;
    }
}