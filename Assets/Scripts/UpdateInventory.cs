using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateInventory : MonoBehaviour
{

	public void updateText()
	{
		GetComponent<TextMeshProUGUI>().text = "1" + GetComponent<TextMeshProUGUI>().text.Substring(1);
	}

	public void updateCounter(int amount)
	{
		GetComponent<TextMeshProUGUI>().text = amount.ToString();
	}
}
