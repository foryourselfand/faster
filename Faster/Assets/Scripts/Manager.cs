using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject activeSpawner;

    private void Awake()
    {
        activeSpawner = GameObject.Find(string.Format("{0}Spawner", _GameSpawner.GameMode));
    }

    void Start()
    {
        activeSpawner.SetActive(true);
        activeSpawner.GetComponent<_GameSpawner>().SpawnStart();    
    }
}