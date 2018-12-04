using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public GrowDot StartDot;

    protected virtual void Start()
    {
        DontDestroyOnLoad(gameObject);
        Invoke("SpawnStart", 0.1f);
    }

    GridClicker GetFreeGrid()
    {
        GridClicker tempGrid;
        do
        {
            var randomNumber = Random.Range(0, 24);
            var gridName = string.Format("SmallDefaultButton ({0})", randomNumber);
            tempGrid = GameObject.Find(gridName).gameObject.GetComponent<GridClicker>();
        } while (!tempGrid.IsFree);

        tempGrid.IsFree = false;

        return tempGrid;
    }

    void SpawnStart()
    {
        var freeGrid = GetFreeGrid();
        var spawnedDot = Instantiate(StartDot, freeGrid.transform.position, Quaternion.identity);
        spawnedDot.transform.parent = freeGrid.transform;
    }
}