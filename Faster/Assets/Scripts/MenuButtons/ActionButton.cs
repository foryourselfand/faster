using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ActionButton : _MenuButton
{
    protected override void OnMouseUp()
    {
        base.OnMouseUp();

        Debug.Log(string.Format("{0} action", name));
        if (name.EndsWith("Info"))
        {
            //TODO Info action
        }
        else if (name.EndsWith("Rating"))
        {
            //TODO Rating action
        }
    }
}