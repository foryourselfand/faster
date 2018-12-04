using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClicker : ButtonClicker
{
    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        string scene = name.Split('_')[1];
        SceneManager.LoadScene("Play");
    }

    public IEnumerator changeAlienSprite()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
        }
    }
}