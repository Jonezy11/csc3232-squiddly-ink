using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    private float lastTimeSpawned;
    public float spawnCooldown;

    public GameObject[] debris;

    // Start is called before the first frame update
    void Start()
    {
        lastTimeSpawned = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastTimeSpawned + spawnCooldown) 
        {
            Instantiate(debris[Random.Range(0, debris.Length)], new Vector3(20, Random.Range(-2.4f, 2.4f), 0), Quaternion.identity);
            lastTimeSpawned = Time.time;
        }
    }
}
