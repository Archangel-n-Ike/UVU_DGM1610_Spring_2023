using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();

        if (tempObj == null)
        {
            yield break;
        }

        var otherID = tempObj.idObj;

        if (otherID == idObj)
        {
            Debug.Log("Matched ID");
            matchEvent.Invoke();
        }
        else
        {
            Debug.Log("No Match");
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
