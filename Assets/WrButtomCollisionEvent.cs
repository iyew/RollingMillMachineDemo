using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrButtomCollisionEvent : MonoBehaviour
{
    
    public int buttomFlag;
    public int buttomFlag2;
    public GameObject box;
    public Transform cylinder;
    public GameObject topWr;

    void Start()
    {
        buttomFlag = 0;
    }
    void OnTriggerEnter(Collider other)
    {

        
        if(other.name == "Cylinder")
        {
            box.transform.SetParent(cylinder);
            buttomFlag = 1;
        }

        


        else if(other.name == "Ground")
        {
            box.transform.SetParent(null);
            buttomFlag2 = 1;
        }


    }

    void FixedUpdate()
    {
        var flag = topWr.GetComponent<CylinderCollisionTrigger>().x;

        if(flag == 8)
        {
            buttomFlag = 0;
        }

        else if(flag == 11)
        {
            buttomFlag2 = 0;
        }
    }
}

