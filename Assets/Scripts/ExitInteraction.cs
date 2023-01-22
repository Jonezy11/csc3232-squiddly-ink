using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitInteraction : MonoBehaviour
{
    public SpriteRenderer eKey;
    public BoxCollider2D player;
    public bool interactable;
    public bool interacted;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactable && player.gameObject.GetComponent<InventoryManager>().isReady())
        {
            interacted = true;
            eKey.enabled = false;

            // Return to the main menu
            SceneManager.LoadScene(0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!interacted && col == player && player.gameObject.GetComponent<InventoryManager>().isReady())
        {
            eKey.enabled = true;
            interactable = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (!interacted && col == player && player.gameObject.GetComponent<InventoryManager>().isReady())
        {
            eKey.enabled = false;
            interactable = false;
        }
    }
}
