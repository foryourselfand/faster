using UnityEngine;

public class StartGameDot : GridFillerDot
{
    protected override void actionOnStart()
    {
        GameObject.Find("Manager").GetComponent<Manager>().SpawnNewWave();
        GameObject.Find("StartText").SetActive(false);
    }
}