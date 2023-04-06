using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShieldPickup : MonoBehaviour
{
    void Start()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
        GameObject laser = GameObject.FindGameObjectWithTag("Laser");
        Physics.IgnoreCollision(laser.GetComponent<Collider>(), GetComponent<Collider>());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Debug.Log ("Shield get! (+50 hp)");
    }

}
