using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : _MenuButton
{
    public _GameSpawner gameSpawner;

    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        SceneManager.LoadScene("Play");
        gameSpawner.gameObject.SetActive(true);
    }
}