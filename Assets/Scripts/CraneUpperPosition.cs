using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneUpperPosition : MonoBehaviour
{
    public GameObject WrTop;
    public int flag;
    public float speed;
    public int upperFlag;
    public int upperFlag2;
    public int upperFlag3;
    public int upperFlag4;

    void Start()
    {
        upperFlag = 0;
        upperFlag2 = 0;
        upperFlag3 = 0;
        upperFlag4 = 0;
    }
    void Update()
    {
       flag = WrTop.GetComponent<CylinderCollisionTrigger>().x;
       Vector3 carPosition = new Vector3(0.3294f,0.225f,-0.031f);
       Vector3 putPosition = new Vector3(0.4066f,0.225f,-0.031f);
       Vector3 putPosition2 = new Vector3(0.4466f,0.225f,-0.031f);
       speed = 0.1f;
       

       if(flag == 3)
       {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition,putPosition,speed*Time.deltaTime);
        if(transform.localPosition.x == 0.4066f)
        {
            upperFlag = 1;
        }
       }

       else if(flag == 4)
       {
         upperFlag = 0;
       }

       else if(flag == 6)
       {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition,carPosition,speed * Time.deltaTime);
        if(transform.localPosition.x == 0.3294f)
        {
            upperFlag2 = 1;
        }

    
       }

       else if(flag == 7)
       {
         upperFlag2 = 0;

       }

       if(flag == 9)
       {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition,putPosition2,speed*Time.deltaTime);
        if(transform.localPosition.x == 0.4466f)
        {
            upperFlag3 = 1;
        }
       }

       else if(flag == 10)
       {
         upperFlag3 = 0;
       }

       else if(flag == 12)
       {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition,carPosition,speed * Time.deltaTime);
        if(transform.localPosition.x == 0.3294f)
        {
            upperFlag4 = 1;
        }
        
       }

    

       
    }
}
