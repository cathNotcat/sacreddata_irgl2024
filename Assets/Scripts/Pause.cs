using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseCanvas;
    private GameManager gameManager;
    // Start is called before the first frame update
    private void Start()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
        gameManager = GetComponent<GameManager>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    } 
    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
