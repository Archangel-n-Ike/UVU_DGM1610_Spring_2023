using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // Move GameObject forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
