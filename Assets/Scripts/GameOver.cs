using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager gameManager;
    private void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameManager.GameOver();
            Debug.Log("hit");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameManager.GameOver();
            Debug.Log("hit");
        }
    }
}
