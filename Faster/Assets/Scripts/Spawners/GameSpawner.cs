using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameSpawner : MonoBehaviour
{
    protected void FindCell()
    {
    }

    protected abstract void SpawnNewDot();
}