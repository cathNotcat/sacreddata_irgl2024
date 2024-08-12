using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource lose;
    public GameObject gameOverCanvas;
    public GameObject gameCompletedCanvas;
    private int score = EasyScore.score;
    // private int hsscore;

    [SerializeField] ResultUIManager resultUIManagerScript;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        gameCompletedCanvas.SetActive(false);
        Time.timeScale = 1;
        // hsscore = PlayerPrefs.GetInt("EasyHS");

    }
    public void GameOver()
    {
        lose.Play();
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Completed()
    {
        gameCompletedCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("New Scene");
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void TriggerGameLose()
    {
        resultUIManagerScript.IsGameWin = false;
        resultUIManagerScript.GameScore = score;
        resultUIManagerScript.ShowSubmittingUI();
        Time.timeScale = 0;
        Debug.Log("lose: " + score.ToString());
    }

    public void TriggerGameWin()
    {
        resultUIManagerScript.IsGameWin = true;
        resultUIManagerScript.GameScore = score;
        resultUIManagerScript.ShowSubmittingUI();
        Time.timeScale = 0;
        Debug.Log("win: " + score.ToString());
    }

}
