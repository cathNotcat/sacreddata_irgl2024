using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public GameObject RulesCanvas;
    public GameObject Canvas;
    public GameObject Other;
    // Start is called before the first frame update
    void Start()
    {
        RulesCanvas.SetActive(false);
        Canvas.SetActive(true);
        Other.SetActive(true);
    }
    public void RulesButton()
    {
        RulesCanvas.SetActive(true);
        Canvas.SetActive(false);
        Other.SetActive(false);
    }
    public void BackButton()
    {
        RulesCanvas.SetActive(false);
        Canvas.SetActive(true);
        Other.SetActive(true);
    }
}
