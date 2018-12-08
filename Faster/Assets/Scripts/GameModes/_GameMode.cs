using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _GameMode : MonoBehaviour
{
    public static int isPlaying = 1;
    public static string GameMode;
    public static bool Addition;
    public static int currentScore;
    public GameObject startDot;
    public GameObject dotToSpawn;
    public GameObject decreasingType;
    protected float secTillNext = 1;

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
        isPlaying = 1;
        ResetValues();
        StartCoroutine(SpawnDots());
    }

    public abstract void ResetValues();

    public virtual IEnumerator SpawnDots()
    {
        while (isPlaying == 1)
        {
            ActionInCoroutine();
            yield return new WaitForSeconds(secTillNext);
        }
    }

    protected abstract void ActionInCoroutine();

    private GridClicker GetFreeGrid()
    {
        GridClicker tempGrid;
        do
        {
            var randomNumber = Random.Range(0, 24);
            var gridName = string.Format("SmallDefaultButton ({0})", randomNumber);
            tempGrid = GameObject.Find(gridName).gameObject.GetComponent<GridClicker>();
            if (!tempGrid.isFree)
                Debug.Log(tempGrid.name);
        } while (!tempGrid.isFree);

        tempGrid.isFree = false;

        return tempGrid;
    }

    public void GameOver()
    {
        isPlaying = 0;
        StopCoroutine(SpawnDots());
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