using UnityEngine;

public class DecreaseLifeDot : AlwaysDot
{
    protected override void actionOnStart()
    {
        GameObject.Find("Manager").GetComponent<Manager>().GetActiveMode().DecreaseHearth();
    }
    
    protected override void actionOnEnd()
    {
        GameObject.Find("Manager").GetComponent<Manager>().GetActiveMode().LastCheck();
        count = -1;
    }
}