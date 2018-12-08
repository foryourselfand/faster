using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _GameMode : MonoBehaviour
{
    public static string GameMode;
    public static bool Addition;
    public static int currentScore;
    public GameObject startDot;
    public GameObject dotToSpawn;
    public GameObject decreasingType;

    protected virtual void Start()
    {
        gameObject.SetActive(false);
        decreasingType.SetActive(false);
    }

    public abstract void ChangeIfAddition();

    public void Activate()
    {
        gameObject.SetActive(true);
        decreasingType.SetActive(true);
        ChangeIfAddition();
    }

    public void FirstSpawn()
    {
        Debug.Log("Once");
        ResetValues();
        StartCoroutine(SpawnDots());
    }

    public abstract void ResetValues();

    public abstract IEnumerator SpawnDots();

    private GridClicker GetFreeGrid()
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

    protected GameObject SpawnNewDot(GameObject newDot)
    {
        var freeGrid = GetFreeGrid();
        var spawnedDot = Instantiate(newDot, freeGrid.transform.position, Quaternion.identity);
        spawnedDot.transform.parent = freeGrid.transform;
        return spawnedDot;
    }

    public void SpawnStart()
    {
        var spawnedDot = SpawnNewDot(startDot);
        GameObject.Find("StartText").transform.position = spawnedDot.transform.position;
    }
}