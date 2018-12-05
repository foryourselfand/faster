using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DotSpawner : MonoBehaviour
{
    public _GrowDot dotToSpawn;
    protected _GrowDot child;

    protected void SpawnDot()
    {
        child = Instantiate(dotToSpawn, transform.position, Quaternion.identity);
        child.transform.parent = gameObject.transform;
    }
}