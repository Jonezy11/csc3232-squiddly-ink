using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkProjectile : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set projectile in motion
        rb.velocity = transform.right * speed;
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        if (collider.gameObject.layer == 6)
        {
            
            // Apply damage to an enemy and despawn the projectile
            collider.gameObject.GetComponent<HealthBase>().takeDamage(1);
            Destroy(gameObject);
        }
	}
}
