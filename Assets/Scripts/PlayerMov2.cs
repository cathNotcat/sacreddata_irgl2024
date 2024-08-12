using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov2 : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject folder1Spawner;
    public GameObject folder2Spawner;
    public GameObject folder3Spawner;
    public GameObject rockSpawner;
    public float speed = 8f;
    public float rockSpawnTime;
    private float timeElapsed = 0;
    private ObstacleSpawner spawnerScript;
    private ObstacleSpawner rockScript;
    private Vector2 direction;
    private bool active;
    public AudioSource addSound;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    [SerializeField] private LayerMask groundLM;
    void Start()
    {
        spawnerScript = folder1Spawner.GetComponent<ObstacleSpawner>();
        spawnerScript = folder2Spawner.GetComponent<ObstacleSpawner>();
        spawnerScript = folder3Spawner.GetComponent<ObstacleSpawner>();

        rockScript = rockSpawner.GetComponent<ObstacleSpawner>();
        active = false;
    }
    void Update()
    {
        Movement();

        if (transform.position.y < -5)
        {
            gameManager.GameOver();
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), transform.position.y, transform.position.z);

        if (active == true)
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed > 5)
            {
                speed = 8f;
                spawnerScript.maxTime = 1;
                rockScript.maxTime = rockSpawnTime;
                timeElapsed = 0;

                active = false;
            }
        }
    }
    private void Movement()
    {

        direction.x = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x -= 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x += 1;
        }

        transform.position += new Vector3(direction.x, 0, 0) * speed * Time.deltaTime;

        if (direction.x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if (direction.x > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }

        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            float jumpVel = 18f;
            rb.velocity = Vector2.up * jumpVel;
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D rc = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0, Vector2.down, .1f, groundLM);

        return rc.collider != null;
    }
    void OnTriggerEnter2D(Collider2D collide)
    {
        GameObject otherobj = collide.gameObject;
        // Debug.Log(otherobj);

        if (collide.gameObject.tag == "Rock")
        {
            gameManager.TriggerGameLose();
        }

        else if (collide.gameObject.tag == "folder2")
        {
            EasyScore.score += 100;
            Debug.Log("Score: " + EasyScore.score);
        }

        else if (collide.gameObject.tag == "folder1")
        {
            EasyScore.score -= 5;
            Debug.Log("Score after deduction: " + EasyScore.score);
        }

        else if (collide.gameObject.tag == "folder3")
        {
            EasyScore.score -= 5;
            Debug.Log(EasyScore.score);
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject otherobj = col.gameObject;
        Debug.Log(otherobj);
    }
}