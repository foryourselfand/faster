using UnityEngine;

public class GameOverDot : AlwaysDot
{
    protected override void actionOnStart()
    {
        GameObject.Find("Manager").GetComponent<Manager>().GetActiveMode().GameOver();
    }
}