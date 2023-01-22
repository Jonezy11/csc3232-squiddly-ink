using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthBase
{

    System.Random rand = new System.Random();

    public GameObject coin;
    public GameObject dynamite;

	private void Start()
	{
        hp = 2;
	}

	// Update is called once per frame
	void Update()
    {
        if (hp == 0)
        {
            Vector3 randPos = transform.position;
            // Generate a random number of coins within range
            int range = rand.Next(1, 6);
            for (int i = 0; i < range; i++)
            {
                randPos = transform.position;
                // Add a small random offset to the spawn positions
                randPos.x = randPos.x + Random.Range(-2.0f, 2.0f);
                Instantiate(coin, randPos, Quaternion.identity);
            }
            randPos = transform.position;
            randPos.x = randPos.x + Random.Range(-2.0f, 2.0f);
            Instantiate(dynamite, randPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
