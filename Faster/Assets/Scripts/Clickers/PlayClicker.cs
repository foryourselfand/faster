using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClicker : ButtonClicker
{
    public GameSpawner gameSpawner;

    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        SceneManager.LoadScene("Play");
        gameSpawner.gameObject.SetActive(true);
    }
}