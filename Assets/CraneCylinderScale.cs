using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneCylinderScale : MonoBehaviour
{
    
    public int flag;
    public GameObject WRtop;
    public float y;
    private bool flag2;
    public int k;
    public int t;
    public  int t21;
    public int t3;
    public float y2, y3;

    void Start()
    {
        flag = 0;
        k = 0;
        t = 0;
        t21 =0;
        t3 =0;
        
        
        flag2 = false;
        
        
    }
    void Update()
    {
        flag = WRtop.GetComponent<CylinderCollisionTrigger>().x;
        y = transform.localScale.y;
        y2 = transform.localScale.y;
        y3 = transform.localScale.y;
        
        
        
        if(flag == 1)
        {
        Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
        transform.localScale -= scale;
        }

        else if(flag == 2)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale += scale;

            if(y > -2.2f)
            {
                k = 1;
            }

        }
        else if(flag == 3)
        {
            k = 0;
        }

        else if(flag == 4)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale -= scale; 
        }

        else if(flag == 5)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale += scale;

            if(y > -2.2f)
            {
                t = 1;
            }
        }

        else if(flag == 6)
        {
            t = 0;
        }

         else if(flag == 7)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale -= scale; 
        }

        else if(flag == 8)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale += scale;

            if(y2 > -2.2f)
            {
                t21 = 1;
            }
        }

        else if(flag == 9)
        {
            t21 = 0;
        }

        else if(flag == 10)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale -= scale; 
        }

        else if(flag == 11)
        {
            Vector3 scale = new Vector3(0,2*Time.smoothDeltaTime,0);
            transform.localScale += scale;

            if(y3 > -2.2f)
            {
                t3 = 1;
            }
        }

        else if(flag == 12)
        {
            t3 = 0;        
        }

           
    }



       
       
}
