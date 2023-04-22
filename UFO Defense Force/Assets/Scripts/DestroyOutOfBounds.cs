using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds;
    public float lowBounds;
    public bool gameOverAct;
    
    void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        gameOverAct = GameObject.Find("GameManager");
    }
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBounds)
        {
            Destroy(gameObject);
            GameManager.isGameOver = true;
        }
    }
}
