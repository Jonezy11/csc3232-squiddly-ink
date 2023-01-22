using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveInteraction : MonoBehaviour
{
    public SpriteRenderer eKey;
    public BoxCollider2D player;
    public bool interactable;
    public bool interacted;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactable) 
        {
            interacted = true;
            eKey.enabled = false;

            // Update the player's inventory/UI
            player.gameObject.GetComponent<InventoryManager>().incrementValves();
        }
    }

    // If within range show a tooltip and enable functionality
	void OnTriggerEnter2D(Collider2D col)
	{
        if (!interacted && col == player) 
        {
            eKey.enabled = true;
            interactable = true;
        }
	}

    void OnTriggerExit2D(Collider2D col)
    {
        if (!interacted && col == player)
        {
            eKey.enabled = false;
            interactable = false;
        }
    }
}
