using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridClicker : MonoBehaviour
{
    public GrowDot RedDot;
    [HideInInspector] public bool IsFree = true;
    
    private void OnMouseDown()
    {
        Instantiate(RedDot, transform.position, Quaternion.identity);
        IsFree = false;
    }
}
