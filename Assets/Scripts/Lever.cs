using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    [SerializeField] private UnityEvent _whenForward;
    [SerializeField] private UnityEvent _whenReverse;
    [SerializeField] private UnityEvent _whenStop;
    [SerializeField] private UnityEvent _whenOut;
    //[SerializeField] private UnityEvent _whenIn;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Forward"))
        {
            //Debug.Log("_whenForward");
            _whenForward.Invoke();
        }
        if (other.CompareTag("Reverse"))
        {
            //Debug.Log("_whenReverse");
            _whenReverse.Invoke();
        }
        if (other.CompareTag("Stop"))
        {
            //Debug.Log("_whenStop");
            _whenStop.Invoke();
        }
        if (other.CompareTag("Out"))
        {
            //Debug.Log("_whenOut");
            _whenOut.Invoke();
        }
        /*
        if (other.CompareTag("In"))
        {
            Debug.Log("_whenIn");
            _whenIn.Invoke();
        }
        */
    }

}
