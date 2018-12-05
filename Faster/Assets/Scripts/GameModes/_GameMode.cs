﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _GameMode : MonoBehaviour
{
    [HideInInspector] public static string GameMode;
    public GameObject startDot;

    protected virtual void Start()
    {
        gameObject.SetActive(false);
    }

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
        var freeGrid = GetFreeGrid();
        var spawnedDot = Instantiate(startDot, freeGrid.transform.position, Quaternion.identity);
        spawnedDot.transform.parent = freeGrid.transform;
        GameObject.Find("StartText").transform.position = spawnedDot.transform.position;
    }

    public abstract void SpawnNewWave();
}