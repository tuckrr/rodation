using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitOnClick : MonoBehaviour {

    public void ExitGame()
    {
            Debug.Log("Has quit game");
            Application.Quit();
        }
 
}