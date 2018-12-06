using UnityEngine;

public class Manager : MonoBehaviour
{
    
    private _GameMode activeSpawner;

    private void Awake()
    {
        activeSpawner = GameObject.Find(string.Format("{0}Mode", _GameMode.GameMode)).GetComponent<_GameMode>();
    }

    void Start()
    {
        activeSpawner.Activate();
        activeSpawner.SpawnStart();    
    }

    public void SpawnNewWave()
    {
        activeSpawner.SpawnNewWave();
    }
}