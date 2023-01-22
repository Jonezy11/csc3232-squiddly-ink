using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private int score = 0;

    public void incrementScore() 
    {
        score++;
        tmp.text = score.ToString();
    }
}
