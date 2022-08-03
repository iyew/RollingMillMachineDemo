using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigScale : MonoBehaviour
{
    public int upperFlag;
    public GameObject upper;
    public int scaleFlag;
    public int scaleFlag2;

    void Start()
    {
        scaleFlag = 0;
        scaleFlag2 = 0;
    }
    void Update()
    {
        upperFlag = upper.GetComponent<ZigUpperPosition>().x;
        var speed = 2;
        var y = transform.localScale.y;
        

        if(upperFlag == 3)
        {
            Vector3 scale = new Vector3(0,speed*Time.smoothDeltaTime,0);
            transform.localScale -= scale;
            
        }

        else if(upperFlag == 4)
        {
            Vector3 scale = new Vector3(0,speed*Time.smoothDeltaTime,0);
            transform.localScale += scale;

            if( y > -2.2f)
            {
                scaleFlag = 1;
            }
        }

        else if(upperFlag == 5)
        {
            scaleFlag = 0;
        }

        else if(upperFlag == 6)
        {
            Vector3 scale = new Vector3(0,speed*Time.smoothDeltaTime,0);
            transform.localScale -= scale;
        }

        else if(upperFlag == 7)
        {
            Vector3 scale = new Vector3(0,speed*Time.smoothDeltaTime,0);
            transform.localScale += scale;
            if(y > -2.2f)
            {
                scaleFlag2 = 1;
            }

        }

        else if(upperFlag == 8)
        {
            scaleFlag2 = 0;
        }
    }
}
