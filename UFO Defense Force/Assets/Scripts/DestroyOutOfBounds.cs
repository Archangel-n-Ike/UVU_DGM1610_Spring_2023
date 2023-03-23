using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds;
    public float lowBounds;
    
    void Awake()
    {
        // Time.timeScale = 1;
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
            Debug.Log("Game Over!");
            Destroy(gameObject);
            // Time.timeScale = 0;
        }
    }
}
