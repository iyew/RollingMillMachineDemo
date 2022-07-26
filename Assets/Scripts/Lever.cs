using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    [SerializeField] private UnityEvent _whenForward;
    [SerializeField] private UnityEvent _whenReverse;
    [SerializeField] private UnityEvent _whenStop;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Forward"))
        {
            Debug.Log("_whenForward");
            _whenForward.Invoke();
        }
        if (other.CompareTag("Reverse"))
        {
            Debug.Log("_whenReverse");
            _whenReverse.Invoke();
        }
        if (other.CompareTag("Stop"))
        {
            Debug.Log("_whenStop");
            _whenStop.Invoke();
        }
    }

}
