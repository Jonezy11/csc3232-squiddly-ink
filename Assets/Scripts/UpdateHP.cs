using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHP : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite[] sprites;
    public HealthManager hm;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Switch hearts sprite based on current hp
        if (sr.sprite != sprites[3 - hm.hp]) { sr.sprite = sprites[3 - hm.hp]; }
    }
}
