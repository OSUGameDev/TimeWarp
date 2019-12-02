using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Moving Objects");
        }
    }
    public void playGame()
    {
        
        SceneManager.LoadScene("Moving Objects");
    }
}
