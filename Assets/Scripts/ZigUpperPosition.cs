using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigUpperPosition : MonoBehaviour

{
    public int x;
    public GameObject zig;
    public GameObject cube;
    public GameObject cube2;
    public int startFlag;
    public GameObject buttomBur;
    
    
    void Start()
    {
        x= 0;
        startFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 burPosition = new Vector3(-0.2757f,0.03285716f,-0.05f);
        Vector3 zigPosition = new Vector3(0.425f,0.225f,-0.031f);
        Vector3 zigPosition2 = new Vector3(0.3294f, 0.225f,-0.031f);
        var zigflag = zig.GetComponent<ZigCollisonTrigger>().zigFlag;
        var scaleflag = cube.GetComponent<ZigScale>().scaleFlag;
        var zigflag2 = zig.GetComponent<ZigCollisonTrigger>().zigFlag2;
        var scaleflag2 = cube.GetComponent<ZigScale>().scaleFlag2;
        float speed = 0.1f;
        
        if(x == 1)
        {
            cube2.transform.localPosition = Vector3.MoveTowards(cube2.transform.localPosition,burPosition,speed *Time.deltaTime);
            if(cube2.transform.localPosition.x == -0.2757f)
            {
                x = 2;
            }
        }

        else if(x == 2)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition,zigPosition,speed * Time.deltaTime);
            if(transform.localPosition.x == 0.425f)
            {
                x = 3;
            }
        }

        else if(zigflag == 1)
        {
            x = 4;
        }

        else if(scaleflag == 1)
        {
            x = 5;
        }
        
        

        else if(x == 5)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition,zigPosition2,speed*Time.deltaTime);
            if(transform.localPosition.x == 0.3294f)
            {
                x = 6;
            }
        }

        else if(zigflag2 == 1)
        {
            x = 7;
        }

        else if(scaleflag2 ==1)
        {
            x = 8;
        }

        

    }

    public void pressButton()
    {
        startFlag = buttomBur.GetComponent<PublicBurPosition>().PositionFlag;
        if(startFlag == 1)
        {
        x = 1;
        }
    }
}
