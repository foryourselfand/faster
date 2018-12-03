﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public GameObject buttonOn, buttonOff;

    void Start()
    {
        if (PlayerPrefs.GetString("Music") == "No")
        {
            buttonOn.SetActive(false);
            buttonOff.SetActive(true);
        }
        else
        {
            buttonOn.SetActive(true);
            buttonOff.SetActive(false);
        }
    }

    void OnMouseUp()
    {
        if (PlayerPrefs.GetString("Music") != "No")
        {
            PlayerPrefs.SetString("Music", "No");
            buttonOn.SetActive(false);
            buttonOff.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetString("Music", "Yes");
            buttonOn.SetActive(true);
            buttonOff.SetActive(false);
        }
    }
}