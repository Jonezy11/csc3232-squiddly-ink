using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{

    public BoxCollider2D player;
	public EnemySM enemy;

	// Communicate the player's whereabouts to the enemy state machine
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider == player) 
		{
			enemy.playerInRange = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collider)
	{
		if (collider == player)
		{
			enemy.playerInRange = false;
		}
	}
}
