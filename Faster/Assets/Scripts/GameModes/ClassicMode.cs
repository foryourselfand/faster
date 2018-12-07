using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicMode : _GameMode
{
    private int heartCount;
    
    public override void SpawnNewWave()
    {
        Debug.Log("Classic New Wave");
        StartCoroutine(SpawnDots());
    }
    
    IEnumerator SpawnDots()
    {
        while (true)
        {
            SpawnNewDot(dotToSpawn);
            yield return new WaitForSeconds(1);
        }
    }

    public override void ChangeIfAddition()
    {
        heartCount = 3;
        decreasingType.transform.GetChild(3).gameObject.SetActive(Addition);
        decreasingType.transform.GetChild(4).gameObject.SetActive(Addition);
        if (!Addition)
        {
            decreasingType.transform.position = new Vector3(0f, 0, 0);
        }
        else
        {
            heartCount += 2;
            decreasingType.transform.position = new Vector3(-0.5f, 0, 0);
        }
    }
}