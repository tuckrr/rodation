﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnClick : MonoBehaviour {

    // public GameObject loadingImage;

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
        Debug.Log("Level has loaded!!!");
        //loadingImage.SetActive(true);
    }
}
