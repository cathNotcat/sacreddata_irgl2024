using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float maxTime;
    private float timer = 0;
    public GameObject obstacle;
    private float width = 8;
    private float countdown;
    void Update()
    {
        countdown += Time.deltaTime;
        if (countdown > 3)
        {
            if (timer > maxTime)
            {
                GameObject newobs = Instantiate(obstacle);
                newobs.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0);
                Destroy(newobs, 15);
                timer = 0;

                if (maxTime < 0.5f)
                {
                    maxTime = 0.5f;
                }
                else
                {
                    maxTime -= 0.01f;

                }

            }

            timer += Time.deltaTime;
        }
    }
}