using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterLogic : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource au;
    public float moveSpeed;

    private int move = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            move = 1;
            if (!au.isPlaying) 
            {
                au.Play();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            move = -1;
            if (!au.isPlaying)
            {
                au.Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            au.Pause();
        }
    }

    void FixedUpdate()
    {
        if (move != 0)
        {
            // Set velocity based on input direction and speed
            Vector2 moveVector = transform.up;
            moveVector.y = move * moveVector.y * moveSpeed;
            moveVector.x = rb.velocity.x;
            rb.velocity = moveVector;
            move = 0;
        }
        else 
        {
            rb.velocity = Vector2.zero;
        }
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.gameObject.layer == 6 || collision.collider.gameObject.layer == 7) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
