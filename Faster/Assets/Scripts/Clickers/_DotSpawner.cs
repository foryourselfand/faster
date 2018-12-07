using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DotSpawner : MonoBehaviour
{
    public _GrowDot dotToSpawn;
    protected _GrowDot child;

    public void SpawnDot(_GrowDot dotToSpawn)
    {
        child = Instantiate(dotToSpawn, transform.position, Quaternion.identity);
        child.transform.parent = transform;
    }

    public void SpawnDot()
    {
        SpawnDot(dotToSpawn);
    }
}