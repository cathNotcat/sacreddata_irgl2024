using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject TimeCanvas;
    private float timeRemaining = 0;
    void Start()
    {
        
    }
    void Update()
    {
        timeRemaining = Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            GetComponent<UnityEngine.UI.Text>().text = timeRemaining.ToString();
        }
    }
}
