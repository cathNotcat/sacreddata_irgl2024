using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Hardcore games
public class NextLevel : MonoBehaviour
{
    public float delayBeforeLoad = 30f;
    private float timeElapsed = 0;
    public GameObject TimerCanvas;
    public GameObject TimesUpCanvas;
    public void Start()
    {
        TimesUpCanvas.SetActive(false);
    }
    public void Update()
    {
        timeElapsed += Time.deltaTime;

        if(Mathf.Floor(timeElapsed - 3) > 0)
        {
            GetComponent<UnityEngine.UI.Text>().text = Mathf.Floor(timeElapsed - 3).ToString();

            if(timeElapsed > delayBeforeLoad + 3)
            {                
                TimesUpCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            GetComponent<UnityEngine.UI.Text>().text = 0.ToString();
        }
    }
}
