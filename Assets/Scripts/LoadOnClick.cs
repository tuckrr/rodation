using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

    // public GameObject loadingImage;

    public void LoadScene(int level)
    {
        //Application.LoadLevel(level);
        SceneManager.LoadScene(level);
        Debug.Log("Level has loaded!!!");
        //loadingImage.SetActive(true);
    }
}
