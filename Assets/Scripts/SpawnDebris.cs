using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDebris : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2;
    public float rot = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Set projectile in motion
        rb.velocity = -transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rot));
    }
}
