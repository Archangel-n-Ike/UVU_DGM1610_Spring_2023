using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep score
    public AudioClip explodeSound;
    private AudioSource explodeAudio;
    public TextMeshProUGUI scoreText; // visual element to modify

    void Start()
    {
        explodeAudio = GetComponent<AudioSource>();
    }

    public void IncreaseScore(int amount) // increases score by an amount
    {
        score += amount;
        UpdateScoreText();
        explodeAudio.PlayOneShot(explodeSound, 1.0f);
    }

    public void DecreaseScore(int amount) // decreases score by an amount
    {
        score -= amount;
        UpdateScoreText();
        explodeAudio.PlayOneShot(explodeSound, 1.0f);
    }

    public void UpdateScoreText() // updates HUD score
    {
        scoreText.text = "Score: "+ score;
    }
}
