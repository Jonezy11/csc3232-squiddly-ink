using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaState : HealthBase
{
	public ScoreManager s;

	private void Start()
	{
		hp = 1;
	}

	// Update is called once per frame
	void Update()
    {
        if (hp == 0)
        {
            Destroy(gameObject);
			s.incrementScore();
        }
    }
}
