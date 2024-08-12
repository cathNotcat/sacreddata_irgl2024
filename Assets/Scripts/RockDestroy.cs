using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
