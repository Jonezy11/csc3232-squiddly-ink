using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int coins;
    public int valves;
    public int dynamite;

	// UI updaters
	public UpdateInventory coinsUpdate;
	public UpdateInventory valvesUpdate;
	public UpdateInventory dynamiteUpdate;

	private void Start()
	{
		coins = 0;
		valves = 0;
		dynamite = 0;
	}

	public void incrementCoins() 
	{
		coins += 1;
		coinsUpdate.updateCounter(coins);
	}

	public void incrementValves()
	{
		valves += 1;
		valvesUpdate.updateText();
	}

	public void incrementDynamite()
	{
		dynamite += 1;
		dynamiteUpdate.updateText();
	}

	// Check if the player can complete the level
	public bool isReady()
	{
		return (dynamite == 1 && valves == 1);
	}
}
