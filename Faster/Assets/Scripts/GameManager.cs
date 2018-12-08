using UnityEngine;

public class GameManager : MonoBehaviour
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

    public _GameMode GetActiveMode()
    {
        return activeSpawner;
    }
}