using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private Rigidbody2D rb;
    public BoxCollider2D ec;

    public float jumpForce;
    public float moveSpeed;

    private int move = 0;
    private int jump = 0;

    public bool facingRight = true;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (!facingRight) { flip(); }
            move = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (facingRight) { flip(); }
            move = -1;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            jump = 1;
        }
    }

	void FixedUpdate()
	{
        if (move != 0) 
        {
            // Set velocity based on input direction and speed
            Vector2 moveVector = transform.right;
            moveVector.x = move * moveVector.x * moveSpeed;
            moveVector.y = rb.velocity.y;
            rb.velocity = moveVector;
            move = 0;
        }
    
        if (isGrounded && jump == 1)
        {
            Debug.Log("jump");
            rb.AddForce(transform.up * jumpForce);
            jump = 0;
            isGrounded = false;
        }
    }

    private void flip()
    {
        facingRight = !facingRight;
        
        // Flip sprite
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        /*
        Vector3 scaleVector = transform.localScale;
        scaleVector.x *= -1;
        transform.localScale = scaleVector;
        */
    }

	private void OnCollisionStay2D(Collision2D collision)
	{
        if (collision.otherCollider == ec) 
        {
            isGrounded = true;
        }
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.otherCollider == ec)
        {
            isGrounded = false;
        }
    }
}
