using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [HideInInspector] public static bool[] Field = new bool[24];
    public GrowDot StartDot;

    private void Start()
    {
        SpawnStart();
    }

    public GridClicker GetFreeGrid()
    {
        GridClicker tempGrid;
        do
        {
            int num = Random.Range(0, 24);
            string name = string.Format("SmallDefaultButton ({0})", num);
            Debug.Log(name);
            tempGrid = GameObject.Find(name).gameObject.GetComponent<GridClicker>();
        } while (!tempGrid.IsFree);

        tempGrid.IsFree = false;

        return tempGrid;
    }

    protected void SpawnStart()
    {
        GridClicker temp = GetFreeGrid();
        Instantiate(StartDot, temp.transform.position, Quaternion.identity);
    }
}