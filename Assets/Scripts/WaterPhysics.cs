using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPhysics : MonoBehaviour
{
	// Apply increased drag to player when in water volumes

	public float drag = 3.0f;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.GetComponent<Rigidbody2D>() != null) 
		{
			collision.gameObject.GetComponent<Rigidbody2D>().drag = drag;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
		{
			collision.gameObject.GetComponent<Rigidbody2D>().drag = 0;
		}
	}
}
