using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VibrationTrigger : MonoBehaviour
{

    public OVRInput.Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void vibrationTri()
    {
        OVRInput.SetControllerVibration(0.1f,0.1f,controller);
    }
}
