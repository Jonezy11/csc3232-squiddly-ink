using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPiranha : MonoBehaviour
{
    private float lastTimeSpawned;
    public float spawnCooldown;

    public GameObject p;
    public Transform player;
    public ScoreManager scoreManager;

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
            GameObject sum = Instantiate(p, new Vector3(20, Random.Range(-2.4f, 2.4f), 0), Quaternion.identity);
            AIDestinationSetter a = sum.GetComponent<AIDestinationSetter>();
            a.target = player;
            PiranhaState ps = sum.GetComponent<PiranhaState>();
            ps.s = scoreManager;
            lastTimeSpawned = Time.time;
        }
    }
}
