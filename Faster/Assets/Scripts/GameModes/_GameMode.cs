﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _GameMode : MonoBehaviour
{
    public static string GameMode;
    public static bool Addition;
    public GameObject startDot;
    public GameObject dotToSpawn;
    public GameObject decreasingType;

    protected virtual void Start()
    {
        gameObject.SetActive(false);
        decreasingType.SetActive(false);
    }

    public abstract void SpawnNewWave();

    public abstract void ChangeIfAddition();

    GridClicker GetFreeGrid()
    {
        GridClicker tempGrid;
        do
        {
            var randomNumber = Random.Range(0, 24);
            var gridName = string.Format("SmallDefaultButton ({0})", randomNumber);
            tempGrid = GameObject.Find(gridName).gameObject.GetComponent<GridClicker>();
        } while (!tempGrid.isFree);

        tempGrid.isFree = false;

        return tempGrid;
    }

    public void SpawnStart()
    {
        var spawnedDot = SpawnNewDot(startDot);
        GameObject.Find("StartText").transform.position = spawnedDot.transform.position;
    }

    protected GameObject SpawnNewDot(GameObject newDot)
    {
        var freeGrid = GetFreeGrid();
        var spawnedDot = Instantiate(newDot, freeGrid.transform.position, Quaternion.identity);
        spawnedDot.transform.parent = freeGrid.transform;
        return spawnedDot;
    }


    public void Activate()
    {
        gameObject.SetActive(true);
        decreasingType.SetActive(true);
        ChangeIfAddition();
    }
}