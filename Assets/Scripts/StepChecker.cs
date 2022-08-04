using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StepChecker : MonoBehaviour
{
    [SerializeField] private UnityEvent _whenFinishForward;
    [SerializeField] private UnityEvent _whenFinishReverse;
    [SerializeField] private UnityEvent _whenFinishOut;
    private bool isPassed;

    protected void Start()
    {
        isPassed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Forward"))
        {
            if (!isPassed)
            {
                // Debug.Log("StepChecker: _whenFinishForward");
                isPassed = true;
                _whenFinishForward.Invoke();
            }
        }
        if (other.CompareTag("Reverse"))
        {
            if (isPassed)
            {
                // Debug.Log("StepChecker: _whenFinishReverse");
                isPassed = false;
                _whenFinishReverse.Invoke();
            }
        }
        if (other.CompareTag("Out"))
        {
            if (!isPassed)
            {
                // Debug.Log("StepChecker: _whenFinishOut");
                isPassed = true;
                _whenFinishOut.Invoke();
            }
        }
    }
}
