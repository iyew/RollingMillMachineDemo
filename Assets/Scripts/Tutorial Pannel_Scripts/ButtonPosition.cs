using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPosition : MonoBehaviour
{
    public GameObject machineController;
    float[,] position;

    void Start(){
        position = new float[5, 3]{
        {-0.0767f, 0.8798f, 0.5686f}, //RollForceCylinder
        {0.0747f, 0.8794f, 0.6808f}, //W/R Balance
        {-0.1504f, 0.8798f, 0.5686f}, //Spindle Supportc
        {0.1503f, 0.8794f, 0.63804f}, //W/R Chock
        {0.0747f, 0.8764f, 0.6249f}, //W/R Change
        };
    }

    void Update()
    {
        int i = machineController.GetComponent<Mode>().step-1;
            Vector3 destination = new Vector3(position[i,0], position[i,1], position[i,2]);
            transform.position = Vector3.MoveTowards(transform.position, destination, 1);
    }
}
