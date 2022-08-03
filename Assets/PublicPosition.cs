using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicPosition : MonoBehaviour
{
    public float Posx;
    public int PositionFlag;

    void Start()
    {
        PositionFlag = 0;
    }
    void Update()
    {
        Posx = transform.position.x;
        if(Posx < -5.0f)
        {
            PositionFlag = 1;
        }


    }
}
