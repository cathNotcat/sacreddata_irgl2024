using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyHS : MonoBehaviour
{
    public Text HSText;
    void Start()
    {
        HSText.text = "HIGH SCORE : " + PlayerPrefs.GetInt("EasyHS");
    }
}
