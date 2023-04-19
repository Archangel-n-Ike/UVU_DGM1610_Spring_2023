using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShieldPickup : MonoBehaviour
{
    public UnityEvent startEvent;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Shield Get: + 50 Shield!");
        startEvent.Invoke();
        Destroy(gameObject);
    }
}