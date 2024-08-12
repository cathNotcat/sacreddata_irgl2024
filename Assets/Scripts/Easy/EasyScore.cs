using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyScore : MonoBehaviour
{
    public GameManager gameManager;
    public Text ScoreText;
    public static int score = 0;
    [SerializeField] ResultUIManager resultUIManagerScript;
    private void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    private void Update()
    {
        ScoreText.text = "Score : " + score.ToString();
        if (score < 0)
        {
            // gameManager.GameOver();
            gameManager.TriggerGameLose();
        }
        if (score >= 1000)
        {
            // gameManager.Completed();
            TriggerGameWin();
        }
    }
    public void MenuButton()
    {
        if (score > PlayerPrefs.GetInt("EasyHS"))
        {
            PlayerPrefs.SetInt("EasyHS", score);
        }

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
