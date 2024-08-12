using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject rulesCanvas;

    private void Start()
    {
        rulesCanvas.SetActive(false);
        Time.timeScale = 0;
    }
    public void Play()
    {
        SceneManager.LoadScene(3);
        Debug.Log("New Scene");
    }

    public void Quit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
    public void Easy()
    {
        SceneManager.LoadScene(3);
    }
    public void EasyMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void Rules()
    {
        rulesCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Close()
    {
        rulesCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
