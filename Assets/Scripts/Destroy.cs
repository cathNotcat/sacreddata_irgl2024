using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Prefabs
public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject); //collision.gameObject
        }
    }
    private void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag != "Obstacle" || collider.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
