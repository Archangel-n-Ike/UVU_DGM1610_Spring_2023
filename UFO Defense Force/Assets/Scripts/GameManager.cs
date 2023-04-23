using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;
    private GameObject gameOverText;
    public AudioClip gameOverSound;
    private AudioSource gameOverAudio;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(isGameOver)
        {
            EndGame();
        }
        else
            gameOverText.gameObject.SetActive(false); // keep game over text hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
        gameOverAudio.PlayOneShot(gameOverSound, 1.0f);
    }
}
