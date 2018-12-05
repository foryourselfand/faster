using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : _MenuButton
{
    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        _GameMode.GameMode = name.Split('_')[1];
        SceneManager.LoadScene("Play");
    }
}