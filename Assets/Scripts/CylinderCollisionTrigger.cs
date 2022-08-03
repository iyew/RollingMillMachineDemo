using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderCollisionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    public Transform cylinder;
    public int x;
    public GameObject scaleBox;
    public GameObject upperCrane;
    public GameObject buttomWr;
    
    void Start()
    {
        x = 0;
    }
    void buttonPress()
    {
        x = 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cylinder")
        {
            box.transform.SetParent(cylinder);
            x = 2;
        }

        else if(other.name == "Ground")
        {
            box.transform.SetParent(null);
            x = 5;
        }


    }

    void Update()
    {
        var j = scaleBox.GetComponent<CraneCylinderScale>().k;
        var h = upperCrane.GetComponent<CraneUpperPosition>().upperFlag;
        var r = scaleBox.GetComponent<CraneCylinderScale>().t;
        var o = upperCrane.GetComponent<CraneUpperPosition>().upperFlag2;
        var p = buttomWr.GetComponent<WrButtomCollisionEvent>().buttomFlag;
        var r2 = scaleBox.GetComponent<CraneCylinderScale>().t21;
        var o2 = upperCrane.GetComponent<CraneUpperPosition>().upperFlag3;
        var p2 = buttomWr.GetComponent<WrButtomCollisionEvent>().buttomFlag2;
        var r3 = scaleBox.GetComponent<CraneCylinderScale>().t3;
        var o3 = upperCrane.GetComponent<CraneUpperPosition>().upperFlag4;


        if(j == 1)
        {
            x = 3;
        }

        else if(h == 1)
        {
            x = 4;
        }

        else if( r == 1)
        {
            x = 6;
        }

        else if(o == 1)
        {
            x = 7;
        }

        else if(p == 1)
        {
            x = 8;
        }

        else if(r2 == 1)
        {
            x = 9;
        }

        else if(o2 == 1)
        {
            x = 10;
        }

        else if(p2 ==1)
        {
            x = 11;
        }

        else if(r3 == 1)
        {
            x = 12;
        }

        else if(o3 == 1)
        {
            x = 13;
        }

    }
}
