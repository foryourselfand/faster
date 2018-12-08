using UnityEngine;

public class GameOverDot : AlwaysDot
{
    protected override void actionOnStart()
    {
        GameObject.Find("Manager").GetComponent<GameManager>().GetActiveMode().GameOver();
    }
    
    protected override void actionOnEnd()
    {
        Debug.Log("Game Over Screen");
    }
}