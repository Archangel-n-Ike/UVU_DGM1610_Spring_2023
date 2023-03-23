using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject laser;

    void Update()
    {
        // Set horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        // Keep player within bounds
        // Left wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        // Right wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }

        // Create laser at the blaster's location (position + rotation)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
        }
    }
    
    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
}
