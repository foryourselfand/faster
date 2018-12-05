using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject activeSpawner;

    void Start()
    {
        activeSpawner = GameObject.Find(string.Format("{0}Spawner", _GameSpawner.GameMode));
        activeSpawner.SetActive(true);
    }
}