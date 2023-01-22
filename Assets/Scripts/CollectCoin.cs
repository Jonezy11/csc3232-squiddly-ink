using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
	// Update the counter then despawn the drop
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.GetComponent<InventoryManager>() != null) 
		{
			// Call the player's inventory manager
			collision.gameObject.GetComponent<InventoryManager>().incrementCoins();
			Destroy(gameObject);
		}
	}
}
