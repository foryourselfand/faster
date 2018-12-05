using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject activeSpawner;

    private void Awake()
    {
        Debug.Log(_GameSpawner.GameMode);
        activeSpawner = GameObject.Find(string.Format("{0}Spawner", _GameSpawner.GameMode));
    }

    void Start()
    {
        activeSpawner.SetActive(true);
    }
}