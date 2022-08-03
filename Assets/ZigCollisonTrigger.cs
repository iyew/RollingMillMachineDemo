using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigCollisonTrigger : MonoBehaviour
{
    public int x;
    public Transform cylinder;
    public GameObject zig;
    public int zigFlag;
    public int zigFlag2;
    public GameObject upper;
    public Transform buttomBur;
    
    void Start(){
        zigFlag = 0;
        zigFlag2 = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cylinder")
        {
            zig.transform.SetParent(cylinder);
            zigFlag = 1;

        }

        else if(other.name == "BOX:1")
        {
            zig.transform.SetParent(buttomBur);
            zigFlag2 = 1;
        }
    }

    void Update()
    {
        var flag = upper.GetComponent<ZigUpperPosition>().x;

        if(flag == 4)
        {
            zigFlag = 0;
        }

        else if(flag == 7)
        {
            zigFlag2 = 0;
        }
    }
    
}
