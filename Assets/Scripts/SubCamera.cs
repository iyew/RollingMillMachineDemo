using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : MonoBehaviour
{
    private Transform target;
 
    public void ChangeCameraView(Transform target)
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
