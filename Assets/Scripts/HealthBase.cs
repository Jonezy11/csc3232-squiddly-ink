using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthBase : MonoBehaviour
{
    public int hp;

    public void takeDamage(int amount)
    {
        hp = hp - amount;
    }
}
