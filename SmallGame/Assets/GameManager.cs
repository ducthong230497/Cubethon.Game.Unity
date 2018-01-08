using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool gameOver = false;
    public float timeToRestart;
    public GameObject levelComplete;
    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart", timeToRestart);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        levelComplete.SetActive(true);
    }
}
