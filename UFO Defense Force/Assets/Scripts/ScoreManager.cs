using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep score
    public TextMeshProUGUI scoreText; // visual element to modify

    public void IncreaseScore(int amount) // increases score by an amount
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // decreases score by an amount
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // updates HUD score
    {
        scoreText.text = "Score: "+ score;
    }
}
