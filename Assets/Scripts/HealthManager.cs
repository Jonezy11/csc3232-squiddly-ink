using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int hp;
    private float graceTime = 0;

    private bool disableCol = false;

    void Update()
    {
        if (hp == 0)
        {
            // Reset level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex) ;
        }
        /*
        if (graceTime < Time.time && disableCol) 
        {
            //Physics2D.IgnoreCollision(enemy, player, false);
            disableCol = false;
        }
        */
    }

    public void takeDamage(int amount) 
    {
        if (graceTime < Time.time)
        {
            hp = hp - amount;
            // Make player briefly invincible
            graceTime = Time.time + 2;
        }
    }

    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 && graceTime > Time.time)
        {
            //Physics2D.IgnoreCollision(enemy, player);
            disableCol = true;
        }
    }
    */
}
