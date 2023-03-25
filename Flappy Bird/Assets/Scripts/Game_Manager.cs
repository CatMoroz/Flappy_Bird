using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameOverScoreCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOverScoreCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
