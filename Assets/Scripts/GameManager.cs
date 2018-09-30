using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    bool gameEnded = false;

    public float restartDelay = 1.5f;
	// Use this for initialization
	public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");

            //Instantly restarts function
            //Restart();

            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level1");
        //for specific scenes.

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        //fixing strange lighting errors after restarting level:
        //go to "Lighting" and uncheck "Autogenerate" on the bottom
        //and then click Generate Lighting. 
        //Something to do with unity doesn't have enough time to
        //recalulate lightings.
    }
}
