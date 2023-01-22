using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private float projectileSpawn = 0f;

    public float projectileCooldown;
    public GameObject projectile;
    public AudioSource au;

    private bool facingRight;
    private Movement2D move;

    void Start()
    {
        move = GetComponent<Movement2D>();
    }

    void Update()
    {
        facingRight = move.facingRight;
        // Spawn if the previous cooldown has elapsed
        if (Input.GetKeyDown(KeyCode.F) && Time.time > projectileSpawn + projectileCooldown) 
        {
            // Set projectile rotation based on player facing
            Quaternion rot = Quaternion.identity;
            if (!facingRight) 
            {
                Vector3 angles = rot.eulerAngles += new Vector3(0, 180, 0);
                rot.eulerAngles = angles;
            }
            Instantiate(projectile, transform.position, rot);
            projectileSpawn = Time.time;
            au.Play();
        }
    }
}
