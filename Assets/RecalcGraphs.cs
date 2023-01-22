using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RecalcGraphs : MonoBehaviour
{
    public AstarPath p;

    // Update is called once per frame
    void Update()
    {
        p.Scan();
    }
}
