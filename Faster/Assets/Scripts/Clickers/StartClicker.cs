using UnityEngine;

public class StartClicker : MaskClicker
{
    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        
        GameObject.Find("Manager").GetComponent<Manager>().SpawnNewWave();
        GameObject.Find("StartText").SetActive(false);
    }
}