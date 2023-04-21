using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; // store reference to score manager
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find ScoreManager and reference ScoreManager script component
    }

    void OnTriggerEnter(Collider other) // stores record of collision in "other"
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}