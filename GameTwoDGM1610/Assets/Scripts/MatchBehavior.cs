using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idoObj;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idoObj);
    }
}
