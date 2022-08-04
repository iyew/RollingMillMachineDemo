using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Oculus.Interaction
{
    public class Lever : MonoBehaviour
    {
        [SerializeField] private UnityEvent _whenForward;
        [SerializeField] private UnityEvent _whenReverse;
        [SerializeField] private UnityEvent _whenStop;
        [SerializeField] private UnityEvent _whenOut;
        // [SerializeField] private UnityEvent _whenIn;

        [SerializeField] private UnityEvent _whenFinishForward;
        [SerializeField] private UnityEvent _whenFinishReverse;
        [SerializeField] private UnityEvent _whenFinishOut;

        private Vector3 initStopPosition;
        private Quaternion initStopRotation;
        
        protected void Start()
        {
            initStopPosition = transform.position;
            initStopRotation = transform.rotation;
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Forward"))
            {
                // Debug.Log("_whenForward");
                _whenForward.Invoke();
            }
            if (other.CompareTag("Reverse"))
            {
                // Debug.Log("_whenReverse");
                _whenReverse.Invoke();
            }
            if (other.CompareTag("Stop"))
            {
                // Debug.Log("_whenStop");
                _whenStop.Invoke();
            }
            if (other.CompareTag("Out"))
            {
                // Debug.Log("_whenOut");
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

        public void FinishForward()
        {
            // Debug.Log("Lever: _whenFinishForward");
            _whenFinishForward.Invoke();
        }

        public void FinishReverse()
        {
            // Debug.Log("Lever: _whenFinishReverse");
            _whenFinishReverse.Invoke();
        }

        public void FinishOut()
        {
            // Debug.Log("Lever: _whenFinishReverse");
            _whenFinishOut.Invoke();
        }
        
        /*
        public void RevertLever()
        {
            transform.position = initStopPosition;
            transform.rotation = initStopRotation;

            GetComponent<OneGrabRotateTransformer>().EndTransform();
            float k = GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle;
            
            if (-20 <= k && k <= 20)
            {
                GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle = 0 ;
            }
            else if (20 < k && k < 60)
            {
                GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle = 45;
            }
            else if(-60 < k && k < -20)
            {
                GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle = -45 ;   
            }
            else if(60 <= k && k <= 90)
            {
                GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle = 90 ;
            }
            else if(-90 <= k && k <= -60)
            {
                GetComponent<OneGrabRotateTransformer>()._constrainedRelativeAngle = -90 ;
            }
        }
        */

        /*
        public void Success()
        {
            Debug.Log("Success");
        }
        */
    }
}