using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //so we can use scene manager
public class gameOver : MonoBehaviour {

    // Use this for initialization
    public static bool gameIsOver = false;
    public GameObject gameOverUI;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameIsOver)
        {
            Pause();
        }
       
	}

    void Pause ()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsOver = true;
    }

    public void Restart()
    {
        Debug.Log("Restarting Game");
        Time.timeScale = 1f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Moving Objects");
        gameIsOver = false;
    }

    public void getMainScreen ()
    {
        Restart();
        SceneManager.LoadScene("mainMenu");
    }
}
